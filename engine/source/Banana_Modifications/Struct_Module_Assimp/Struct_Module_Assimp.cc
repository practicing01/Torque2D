//Modular Banana by practicing01

#ifndef _CONSOLE_H_
#include "console/console.h"
#endif

#include <string.h>
#include "Struct_Module_Assimp.h"

#include <stdlib.h>
#include <stdio.h>

//#include <GL/glut.h>
//#include <GL/gl.h>
#include "math/mRect.h"

#ifndef _PLATFORM_H_
#include "platform/platform.h"
#endif

#ifndef _PLATFORMGL_H_
#include "platform/platformAssert.h"
#include "platform/platformGL.h"
#endif
#include "graphics/dgl.h"

/*#define GL_FUNCTION(fn_return,fn_name,fn_args,fn_value) extern fn_return (*fn_name)fn_args;
#include "platform/GLCoreFunc.h"
#include "platform/GLExtFunc.h"
#undef GL_FUNCTION
*/
// GLU functions are linked at compile time, except in the dedicated server build
/*#ifndef DEDICATED
#define GL_FUNCTION(fn_return,fn_name,fn_args,fn_value) fn_return fn_name fn_args;
#else
#define GL_FUNCTION(fn_return,fn_name,fn_args,fn_value) extern fn_return (*fn_name)fn_args;
#endif
#include "platform/GLUFunc.h"
#undef GL_FUNCTION
*/
// assimp include files. These three are usually needed.
#include <assimp/cimport.h>
#include <assimp/scene.h>
#include <assimp/postprocess.h>

/****************************************************************/

//http://iphonedevelopment.blogspot.com/2008/12/glulookat.html
//Jeff LaMarche

void gluLookAt(GLfloat eyex, GLfloat eyey, GLfloat eyez,
          GLfloat centerx, GLfloat centery, GLfloat centerz,
          GLfloat upx, GLfloat upy, GLfloat upz)
{
    GLfloat m[16];
    GLfloat x[3], y[3], z[3];
    GLfloat mag;

    //* Make rotation matrix

    //* Z vector
    z[0] = eyex - centerx;
    z[1] = eyey - centery;
    z[2] = eyez - centerz;
    mag = sqrt(z[0] * z[0] + z[1] * z[1] + z[2] * z[2]);
    if (mag) {          //* mpichler, 19950515
        z[0] /= mag;
        z[1] /= mag;
        z[2] /= mag;
    }

    //* Y vector
    y[0] = upx;
    y[1] = upy;
    y[2] = upz;

    //* X vector = Y cross Z
    x[0] = y[1] * z[2] - y[2] * z[1];
    x[1] = -y[0] * z[2] + y[2] * z[0];
    x[2] = y[0] * z[1] - y[1] * z[0];

    //* Recompute Y = Z cross X
    y[0] = z[1] * x[2] - z[2] * x[1];
    y[1] = -z[0] * x[2] + z[2] * x[0];
    y[2] = z[0] * x[1] - z[1] * x[0];

    //* mpichler, 19950515
    //* cross product gives area of parallelogram, which is < 1.0 for
    // * non-perpendicular unit-length vectors; so normalize x, y here
    //

    mag = sqrt(x[0] * x[0] + x[1] * x[1] + x[2] * x[2]);
    if (mag) {
        x[0] /= mag;
        x[1] /= mag;
        x[2] /= mag;
    }

    mag = sqrt(y[0] * y[0] + y[1] * y[1] + y[2] * y[2]);
    if (mag) {
        y[0] /= mag;
        y[1] /= mag;
        y[2] /= mag;
    }

#define M(row,col)  m[col*4+row]
    M(0, 0) = x[0];
    M(0, 1) = x[1];
    M(0, 2) = x[2];
    M(0, 3) = 0.0;
    M(1, 0) = y[0];
    M(1, 1) = y[1];
    M(1, 2) = y[2];
    M(1, 3) = 0.0;
    M(2, 0) = z[0];
    M(2, 1) = z[1];
    M(2, 2) = z[2];
    M(2, 3) = 0.0;
    M(3, 0) = 0.0;
    M(3, 1) = 0.0;
    M(3, 2) = 0.0;
    M(3, 3) = 1.0;
#undef M
    glMultMatrixf(m);

    ///* Translate Eye to Origin
    glTranslatef(-eyex, -eyey, -eyez);

}

/****************************************************************/

//http://nehe.gamedev.net/article/replacement_for_gluperspective/21002/
//James Heggie

// Replaces gluPerspective. Sets the frustum to perspective mode.
// fovY     - Field of vision in degrees in the y direction
// aspect   - Aspect ratio of the viewport
// zNear    - The near clipping distance
// zFar     - The far clipping distance
/*
void perspectiveGL( GLdouble fovY, GLdouble aspect, GLdouble zNear, GLdouble zFar )
{
	const GLdouble pi = 3.1415926535897932384626433832795;
	GLdouble fW, fH;
	fH = tan( fovY / 360 * pi ) * zNear;
	fW = fH * aspect;
    glFrustum( -fW, fW, -fH, fH, zNear, zFar );
}
*/
/****************************************************************/

// the global Assimp scene object
const struct aiScene* scene = NULL;
GLuint scene_list = 0;
aiVector3D scene_min, scene_max, scene_center;

// current rotation angle
static float angle = 0.f;

#define aisgl_min(x,y) (x<y?x:y)
#define aisgl_max(x,y) (y>x?y:x)

void reshape(int width, int height)
{return;
        const double aspectRatio = (float) width / height, fieldOfView = 45.0;

        glMatrixMode(GL_PROJECTION);
        glLoadIdentity();
        gluPerspective(fieldOfView, aspectRatio,
                1.0, 1000.0); /* Znear and Zfar */
        //perspectiveGL(fieldOfView, aspectRatio,
                //1.0, 1000.0);
        glViewport(0, 0, width, height);
}

void get_bounding_box_for_node (const struct aiNode* nd,
        aiVector3D* min,
        aiVector3D* max,
        aiMatrix4x4* trafo
){
        aiMatrix4x4 prev;
        unsigned int n = 0, t;

        prev = *trafo;
        aiMultiplyMatrix4(trafo,&nd->mTransformation);

        for (; n < nd->mNumMeshes; ++n) {
                const struct aiMesh* mesh = scene->mMeshes[nd->mMeshes[n]];
                for (t = 0; t < mesh->mNumVertices; ++t) {

                        aiVector3D tmp = mesh->mVertices[t];
                        aiTransformVecByMatrix4(&tmp,trafo);

                        min->x = aisgl_min(min->x,tmp.x);
                        min->y = aisgl_min(min->y,tmp.y);
                        min->z = aisgl_min(min->z,tmp.z);

                        max->x = aisgl_max(max->x,tmp.x);
                        max->y = aisgl_max(max->y,tmp.y);
                        max->z = aisgl_max(max->z,tmp.z);
                }
        }

        for (n = 0; n < nd->mNumChildren; ++n) {
                get_bounding_box_for_node(nd->mChildren[n],min,max,trafo);
        }
        *trafo = prev;
}

void get_bounding_box (aiVector3D* min, aiVector3D* max)
{
        aiMatrix4x4 trafo;
        aiIdentityMatrix4(&trafo);

        min->x = min->y = min->z = 1e10f;
        max->x = max->y = max->z = -1e10f;
        get_bounding_box_for_node(scene->mRootNode,min,max,&trafo);
}

void color4_to_float4(const aiColor4D *c, float f[4])
{
        f[0] = c->r;
        f[1] = c->g;
        f[2] = c->b;
        f[3] = c->a;
}

void set_float4(float f[4], float a, float b, float c, float d)
{
        f[0] = a;
        f[1] = b;
        f[2] = c;
        f[3] = d;
}

void apply_material(const struct aiMaterial *mtl)
{
        float c[4];

        GLenum fill_mode;
        int ret1, ret2;
        aiColor4D diffuse;
        aiColor4D specular;
        aiColor4D ambient;
        aiColor4D emission;
        float shininess, strength;
        int two_sided;
        int wireframe;
        unsigned int max;

        set_float4(c, 0.8f, 0.8f, 0.8f, 1.0f);
        if(AI_SUCCESS == aiGetMaterialColor(mtl, AI_MATKEY_COLOR_DIFFUSE, &diffuse))
                color4_to_float4(&diffuse, c);
        glMaterialfv(GL_FRONT, GL_DIFFUSE, c);

        set_float4(c, 0.0f, 0.0f, 0.0f, 1.0f);
        if(AI_SUCCESS == aiGetMaterialColor(mtl, AI_MATKEY_COLOR_SPECULAR, &specular))
                color4_to_float4(&specular, c);
        glMaterialfv(GL_FRONT, GL_SPECULAR, c);

        set_float4(c, 0.2f, 0.2f, 0.2f, 1.0f);
        if(AI_SUCCESS == aiGetMaterialColor(mtl, AI_MATKEY_COLOR_AMBIENT, &ambient))
                color4_to_float4(&ambient, c);
        glMaterialfv(GL_FRONT, GL_AMBIENT, c);

        set_float4(c, 0.0f, 0.0f, 0.0f, 1.0f);
        if(AI_SUCCESS == aiGetMaterialColor(mtl, AI_MATKEY_COLOR_EMISSIVE, &emission))
                color4_to_float4(&emission, c);
        glMaterialfv(GL_FRONT, GL_EMISSION, c);

        max = 1;
        ret1 = aiGetMaterialFloatArray(mtl, AI_MATKEY_SHININESS, &shininess, &max);
        if(ret1 == AI_SUCCESS) {
            max = 1;
            ret2 = aiGetMaterialFloatArray(mtl, AI_MATKEY_SHININESS_STRENGTH, &strength, &max);
                if(ret2 == AI_SUCCESS)
                        glMaterialf(GL_FRONT, GL_SHININESS, shininess * strength);
        else
                glMaterialf(GL_FRONT, GL_SHININESS, shininess);
    }
        else {
                glMaterialf(GL_FRONT, GL_SHININESS, 0.0f);
                set_float4(c, 0.0f, 0.0f, 0.0f, 0.0f);
                glMaterialfv(GL_FRONT, GL_SPECULAR, c);
        }

        max = 1;
        if(AI_SUCCESS == aiGetMaterialIntegerArray(mtl, AI_MATKEY_ENABLE_WIREFRAME, &wireframe, &max))
                fill_mode = wireframe ? GL_LINE : GL_FILL;
        else
                fill_mode = GL_FILL;
        glPolygonMode(GL_FRONT, fill_mode);

        max = 1;
        if((AI_SUCCESS == aiGetMaterialIntegerArray(mtl, AI_MATKEY_TWOSIDED, &two_sided, &max)) && two_sided)
                glDisable(GL_CULL_FACE);
        else
                glEnable(GL_CULL_FACE);
}

void recursive_render (const struct aiScene *sc, const struct aiNode* nd)
{
        unsigned int i;
        unsigned int n = 0, t;
        /*struct*/ aiMatrix4x4 m = nd->mTransformation;

        // update transform
        aiTransposeMatrix4(&m);
        glPushMatrix();
        glMultMatrixf((float*)&m);

        // draw all meshes assigned to this node
        for (; n < nd->mNumMeshes; ++n) {
                const struct aiMesh* mesh = scene->mMeshes[nd->mMeshes[n]];

                apply_material(sc->mMaterials[mesh->mMaterialIndex]);

                //if(mesh->mNormals == NULL) {
                        glDisable(GL_LIGHTING);
                //} else {
                        //glEnable(GL_LIGHTING);
                //}

                for (t = 0; t < mesh->mNumFaces; ++t) {
                        const struct aiFace* face = &mesh->mFaces[t];
                        GLenum face_mode;

                        switch(face->mNumIndices) {
                                case 1: face_mode = GL_POINTS; break;
                                case 2: face_mode = GL_LINES; break;
                                case 3: face_mode = GL_TRIANGLES; break;
                                default: face_mode = GL_POLYGON; break;
                        }

                        face_mode = GL_POLYGON;

                        glBegin(face_mode);

                        for(i = 0; i < face->mNumIndices; i++) {
                                int index = face->mIndices[i];
                                if(mesh->mColors[0] != NULL)
                                        glColor4fv((GLfloat*)&mesh->mColors[0][index]);
                                if(mesh->mNormals != NULL)
                                        glNormal3fv(&mesh->mNormals[index].x);
                                glVertex3fv(&mesh->mVertices[index].x);
                                //printf("x:%f y:%f z:%f\n", mesh->mVertices[index].x,mesh->mVertices[index].y,mesh->mVertices[index].z);
                        }

                        glEnd();
                }

        }

        // draw all children
        for (n = 0; n < nd->mNumChildren; ++n) {
                recursive_render(sc, nd->mChildren[n]);
        }

        glPopMatrix();
}

void do_motion (void)
{
        static GLint prev_time = 0;
        static GLint prev_fps_time = 0;
        static int frames = 0;

        int time = Platform::getRealMilliseconds();//glutGet(GLUT_ELAPSED_TIME);
        angle += (time-prev_time)*0.01;
        prev_time = time;

        frames += 1;
        if ((time - prev_fps_time) > 1000) // update every seconds
    {
        int current_fps = frames * 1000 / (time - prev_fps_time);
        printf("%d fps\n", current_fps);
        frames = 0;
        prev_fps_time = time;
    }


        //glutPostRedisplay ();
}

void display(void)
{

		glEnable(GL_DEPTH_TEST);

        float tmp;

        RectI Previous_Viewport;

        RectI Temp_Viewport;

        dglGetViewport(&Previous_Viewport);

        Temp_Viewport.set(Point2I(0,0),Point2I(800,600));

        dglSetViewport(Temp_Viewport);

        //glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

        glMatrixMode(GL_PROJECTION);
        glPushMatrix();
        glLoadIdentity();

        /*dglSetFrustum(-Temp_Viewport.extent.x*0.5,Temp_Viewport.extent.x*0.5,
        		-Temp_Viewport.extent.y*0.5,Temp_Viewport.extent.y*0.5,-1000.0f,1000.0f,true);*/

        glOrtho(-1.0,1.0,-1.0,1.0,1.0,20.0);

        glMatrixMode(GL_MODELVIEW);
        glPushMatrix();
        glLoadIdentity();
        //gluLookAt(0.f,0.f,3.f,0.f,0.f,-5.f,0.f,1.f,0.f);
        glPolygonMode( GL_FRONT_AND_BACK, GL_FILL );

        // rotate it around the y axis
        glRotatef(angle,1.f,1.f,1.f);

        // scale the whole asset to fit into our view frustum
        tmp = scene_max.x-scene_min.x;
        tmp = aisgl_max(scene_max.y - scene_min.y,tmp);
        tmp = aisgl_max(scene_max.z - scene_min.z,tmp);
        tmp = 1.f / tmp;
        glScalef(tmp, tmp, tmp);

        // center the model
        //glTranslatef( -scene_center.x, -scene_center.y, -scene_center.z );

        glTranslatef( 0.0f, 0.0f, 0.0f );

        // if the display list has not been made yet, create a new one and
        // fill it with scene contents
        //if(scene_list == 0) {
         //scene_list = glGenLists(1);
         //glNewList(scene_list, GL_COMPILE);
            // now begin at the root node of the imported data and traverse
            // the scenegraph by multiplying subsequent local transforms
            // together on GL's matrix stack.
         recursive_render(scene, scene->mRootNode);
         //glEndList();
        //}

        //glCallList(scene_list);

        //glutSwapBuffers();

        glPopMatrix();
        glMatrixMode(GL_PROJECTION);
        glPopMatrix();
        glMatrixMode(GL_MODELVIEW);

        do_motion();

        glDisable(GL_DEPTH_TEST);
}

int loadasset (const char* path)
{
        // we are taking one of the postprocessing presets to avoid
        // spelling out 20+ single postprocessing flags here.
        scene = aiImportFile(path,aiProcessPreset_TargetRealtime_MaxQuality);

        if (scene) {
                get_bounding_box(&scene_min,&scene_max);
                scene_center.x = (scene_min.x + scene_max.x) / 2.0f;
                scene_center.y = (scene_min.y + scene_max.y) / 2.0f;
                scene_center.z = (scene_min.z + scene_max.z) / 2.0f;
                return 0;
        }
        return 1;
}

void Assimp_main(/*int argc, char **argv*/)
{
        struct aiLogStream stream;

        //glutInitWindowSize(900,600);
        //glutInitWindowPosition(100,100);
        //glutInitDisplayMode(GLUT_RGB | GLUT_DOUBLE | GLUT_DEPTH);
        //glutInit(&argc, argv);

        //glutCreateWindow("Assimp - Very simple OpenGL sample");
        //glutDisplayFunc(display);
        //glutReshapeFunc(reshape);
        reshape(800,600);

        // get a handle to the predefined STDOUT log stream and attach
        // it to the logging system. It remains active for all further
        // calls to aiImportFile(Ex) and aiApplyPostProcessing.
        stream = aiGetPredefinedLogStream(aiDefaultLogStream_STDOUT,NULL);
        aiAttachLogStream(&stream);

        // ... same procedure, but this stream now writes the
        // log messages to assimp_log.txt
        stream = aiGetPredefinedLogStream(aiDefaultLogStream_FILE,"assimp_log.txt");
        aiAttachLogStream(&stream);

        // the model name can be specified on the command line. If none
        // is specified, we try to locate one of the more expressive test
        // models from the repository (/models-nonbsd may be missing in
        // some distributions so we need a fallback from /models!).
        //if( 0 != loadasset( argc >= 2 ? argv[1] : "../../test/models-nonbsd/X/dwarf.x")) {
        //        if( argc != 1 || (0 != loadasset( "../../../../test/models-nonbsd/X/dwarf.x") && 0 != loadasset( "../../test/models/X/Testwuson.X"))) {
         //               return -1;
        //        }
        //}

        loadasset( "./Cube.dae");

        //glClearColor(0.1f,0.1f,0.1f,1.f);

        //glEnable(GL_LIGHTING);
        //glEnable(GL_LIGHT0); // Uses default lighting parameters

        //glEnable(GL_DEPTH_TEST);

        //glLightModeli(GL_LIGHT_MODEL_TWO_SIDE, GL_TRUE);
        //glEnable(GL_NORMALIZE);

        // XXX docs say all polygons are emitted CCW, but tests show that some aren't.
        //if(getenv("MODEL_IS_BROKEN"))
                //glFrontFace(GL_CW);

        //glColorMaterial(GL_FRONT, GL_DIFFUSE);

        Platform::getRealMilliseconds();//glutGet(GLUT_ELAPSED_TIME);
        //glutMainLoop();

        // cleanup - calling 'aiReleaseImport' is important, as the library
        // keeps internal resources until the scene is freed again. Not
        // doing so can cause severe resource leaking.
        //aiReleaseImport(scene);

        // We added a log stream to the library, it's our job to disable it
        // again. This will definitely release the last resources allocated
        // by Assimp.
        //aiDetachAllLogStreams();
        //return 0;
}


struct Struct_Module *Pointer_Struct_Module_Assimp=NULL;

struct Struct_Module* Function_Struct_Module_Assimp_Create()
{

Assimp_main();

struct Struct_Module *Struct_Module_Node=(struct Struct_Module*)malloc(sizeof(struct Struct_Module));

return Struct_Module_Node;

}

void Function_Struct_Module_Assimp_Destroy(struct Struct_Module *Pointer_Struct_Module)
{

aiReleaseImport(scene);

aiDetachAllLogStreams();

/******************************************************************************/

if (*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Parents)!=NULL)
{

unsigned int *Pointer_Struct_Module_Linked_List_Node=
(unsigned int*)(*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Parents));

unsigned int *Pointer_Struct_Module_Linked_List_Node_Next;

do
{

Pointer_Struct_Module_Linked_List_Node_Next=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1));

free(Pointer_Struct_Module_Linked_List_Node);

Pointer_Struct_Module_Linked_List_Node=Pointer_Struct_Module_Linked_List_Node_Next;

}
while(Pointer_Struct_Module_Linked_List_Node!=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1)));

}

/******************************************************************************/

if (*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children)!=NULL)
{

unsigned int *Pointer_Struct_Module_Linked_List_Node=
(unsigned int*)(*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children));

unsigned int *Pointer_Struct_Module_Linked_List_Node_Next;

struct Struct_Module *Pointer_Struct_Module_Cast_Linked_List_Node=NULL;

do
{

Pointer_Struct_Module_Linked_List_Node_Next=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1));

Pointer_Struct_Module_Cast_Linked_List_Node=
(struct Struct_Module *)(*(Pointer_Struct_Module_Linked_List_Node+2));

Pointer_Struct_Module_Cast_Linked_List_Node->Pointer_Function_Destroy(Pointer_Struct_Module_Cast_Linked_List_Node);

free(Pointer_Struct_Module_Linked_List_Node);

Pointer_Struct_Module_Linked_List_Node=Pointer_Struct_Module_Linked_List_Node_Next;

}
while(Pointer_Struct_Module_Linked_List_Node!=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1)));

}

/******************************************************************************/

/*if (*(Pointer_Struct_Module->Pointer_Linked_List_Struct_Data)!=NULL)
{

unsigned int *Pointer_Struct_Module_Linked_List_Node=
(unsigned int*)(*(Pointer_Struct_Module->Pointer_Linked_List_Struct_Data));

unsigned int *Pointer_Struct_Module_Linked_List_Node_Next;

do
{

Pointer_Struct_Module_Linked_List_Node_Next=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1));

free(Pointer_Struct_Module_Linked_List_Node);

Pointer_Struct_Module_Linked_List_Node=Pointer_Struct_Module_Linked_List_Node_Next;

}
while(Pointer_Struct_Module_Linked_List_Node!=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1)));

}*/

/******************************************************************************/

free(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Parents);

free(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children);

//free(Pointer_Struct_Module->Pointer_Linked_List_Struct_Data);

free(Pointer_Struct_Module->Pointer_Char_Array_Identifier);

free(Pointer_Struct_Module);

}

void Function_Struct_Module_Assimp_Link(struct Struct_Module *Pointer_Struct_Module_Parent,
struct Struct_Module *Pointer_Struct_Module_Child)
{

	/*

	Linked list format:

	{First_Node, Last_Node}

	Node format:

	{Node_Previous, Node_Next, Data}

	*/

	//New linked list.
	if (*(Pointer_Struct_Module_Parent->Pointer_Struct_Module_Linked_List_Children)==NULL)
	{

	unsigned int *Pointer_Struct_Module_Linked_List_Node=
	(unsigned int*)malloc((sizeof(unsigned int)*2)+sizeof(struct Struct_Module *));

	*(Pointer_Struct_Module_Linked_List_Node)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	*(Pointer_Struct_Module_Linked_List_Node+1)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	*(Pointer_Struct_Module_Linked_List_Node+2)=(unsigned int)Pointer_Struct_Module_Child;

	*(Pointer_Struct_Module_Parent->Pointer_Struct_Module_Linked_List_Children)=
	(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	*(Pointer_Struct_Module_Parent->Pointer_Struct_Module_Linked_List_Children+1)=
	(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	}
	else
	{

	unsigned int *Pointer_Struct_Module_Linked_List_Node_Penultimate=
	(unsigned int*)(*(Pointer_Struct_Module_Parent->Pointer_Struct_Module_Linked_List_Children+1));

	unsigned int *Pointer_Struct_Module_Linked_List_Node=
	(unsigned int*)malloc((sizeof(unsigned int)*2)+sizeof(struct Struct_Module *));

	*(Pointer_Struct_Module_Linked_List_Node_Penultimate+1)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	*(Pointer_Struct_Module_Linked_List_Node)=(unsigned int)Pointer_Struct_Module_Linked_List_Node_Penultimate;

	*(Pointer_Struct_Module_Linked_List_Node+1)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	*(Pointer_Struct_Module_Linked_List_Node+2)=(unsigned int)Pointer_Struct_Module_Child;

	*(Pointer_Struct_Module_Parent->Pointer_Struct_Module_Linked_List_Children+1)=
	(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	}

	/****************************************************************************************/

	if (*(Pointer_Struct_Module_Child->Pointer_Struct_Module_Linked_List_Parents)==NULL)
	{

	unsigned int *Pointer_Struct_Module_Linked_List_Node=
	(unsigned int*)malloc((sizeof(unsigned int)*2)+sizeof(struct Struct_Module *));

	*(Pointer_Struct_Module_Linked_List_Node)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	*(Pointer_Struct_Module_Linked_List_Node+1)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	*(Pointer_Struct_Module_Linked_List_Node+2)=(unsigned int)Pointer_Struct_Module_Parent;

	*(Pointer_Struct_Module_Child->Pointer_Struct_Module_Linked_List_Parents)=
	(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	*(Pointer_Struct_Module_Child->Pointer_Struct_Module_Linked_List_Parents+1)=
	(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	}
	else
	{

	unsigned int *Pointer_Struct_Module_Linked_List_Node_Penultimate=
	(unsigned int*)(*(Pointer_Struct_Module_Child->Pointer_Struct_Module_Linked_List_Parents+1));

	unsigned int *Pointer_Struct_Module_Linked_List_Node=
	(unsigned int*)malloc((sizeof(unsigned int)*2)+sizeof(struct Struct_Module *));

	*(Pointer_Struct_Module_Linked_List_Node_Penultimate+1)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	*(Pointer_Struct_Module_Linked_List_Node)=(unsigned int)Pointer_Struct_Module_Linked_List_Node_Penultimate;

	*(Pointer_Struct_Module_Linked_List_Node+1)=(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	*(Pointer_Struct_Module_Linked_List_Node+2)=(unsigned int)Pointer_Struct_Module_Parent;

	*(Pointer_Struct_Module_Child->Pointer_Struct_Module_Linked_List_Parents+1)=
	(unsigned int)Pointer_Struct_Module_Linked_List_Node;

	}

}

void Function_Struct_Module_Assimp_Loop(struct Struct_Module *Pointer_Struct_Module)
{

display();

//Con::printf("Assimp Loop Struct_Module %d Int_Counter=%d\n",Pointer_Struct_Module,
//Pointer_Struct_Module->Int_Counter);

//Pointer_Struct_Module->Int_Counter++;

/*if (*(Pointer_Struct_Module->Pointer_Linked_List_Struct_Data)!=NULL)
{

unsigned int *Pointer_Struct_Module_Linked_List_Node=
(unsigned int*)(*(Pointer_Struct_Module->Pointer_Linked_List_Struct_Data));

struct Struct_Module *Pointer_Struct_Module_Cast_Linked_List_Node=
(struct Struct_Module *)(*(Pointer_Struct_Module_Linked_List_Node+2));

do
{

Con::printf("Loop Struct_Module Data %d Int_Counter=%d\n",Pointer_Struct_Module_Cast_Linked_List_Node,
Pointer_Struct_Module_Cast_Linked_List_Node->Int_Counter);

Pointer_Struct_Module_Cast_Linked_List_Node->Int_Counter++;

Pointer_Struct_Module_Linked_List_Node=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1));

}
while(Pointer_Struct_Module_Linked_List_Node!=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1)));


}*/

/****************************************************************************************/

if (*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children)==NULL)
{

return;

}

unsigned int *Pointer_Struct_Module_Linked_List_Node=
(unsigned int*)(*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children));

struct Struct_Module *Pointer_Struct_Module_Cast_Linked_List_Node=
(struct Struct_Module *)(*(Pointer_Struct_Module_Linked_List_Node+2));

do
{

if (Pointer_Struct_Module_Cast_Linked_List_Node->Bool_Loop==1)
{

Pointer_Struct_Module_Cast_Linked_List_Node->Pointer_Function_Loop(Pointer_Struct_Module_Cast_Linked_List_Node);

}

Pointer_Struct_Module_Linked_List_Node=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1));

}
while(Pointer_Struct_Module_Linked_List_Node!=(unsigned int*)(*(Pointer_Struct_Module_Linked_List_Node+1)));

}

void Function_Struct_Module_Assimp_Initialize(struct Struct_Module *Pointer_Struct_Module)
{

	Pointer_Struct_Module->Int_Counter=0;

	Pointer_Struct_Module->Bool_Loop=1;

	char *Pointer_Char_Array_Identifier=(char *)malloc(sizeof(char)*512);

	memset(Pointer_Char_Array_Identifier,NULL,512);

	char Char_Array_Identifier[]="Module_Assimp";

	memcpy(Pointer_Char_Array_Identifier,Char_Array_Identifier,sizeof(Char_Array_Identifier));

	Pointer_Struct_Module->Pointer_Char_Array_Identifier=Pointer_Char_Array_Identifier;

	Pointer_Struct_Module->Int_Size_Identifier=sizeof(Char_Array_Identifier);

	Pointer_Struct_Module->Pointer_Function_Create=Function_Struct_Module_Assimp_Create;

	Pointer_Struct_Module->Pointer_Function_Initialize=Function_Struct_Module_Assimp_Initialize;

	Pointer_Struct_Module->Pointer_Function_Destroy=Function_Struct_Module_Assimp_Destroy;

	Pointer_Struct_Module->Pointer_Function_Link=Function_Struct_Module_Assimp_Link;

	//Pointer_Struct_Module->Pointer_Function_Node_Data_Add=Function_Struct_Module_Main_Node_Data_Add;

	Pointer_Struct_Module->Pointer_Function_Loop=Function_Struct_Module_Assimp_Loop;

	/******************************************************************************/

	Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Parents=
	(unsigned int*)malloc((sizeof(unsigned int)*2));

	*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Parents)=NULL;

	*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Parents+1)=NULL;

	/******************************************************************************/

	Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children=
	(unsigned int*)malloc((sizeof(unsigned int*)*2));

	*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children)=NULL;

	*(Pointer_Struct_Module->Pointer_Struct_Module_Linked_List_Children+1)=NULL;

	/******************************************************************************/

	/*Pointer_Struct_Module->Pointer_Linked_List_Struct_Data=
	(unsigned int*)malloc((sizeof(unsigned int)*2));

	*(Pointer_Struct_Module->Pointer_Linked_List_Struct_Data)=NULL;

	*(Pointer_Struct_Module->Pointer_Linked_List_Struct_Data+1)=NULL;

	Pointer_Struct_Module->Pointer_Function_Node_Data_Add(Pointer_Struct_Module);
	*/
	/******************************************************************************/

}
