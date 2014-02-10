#include <stdio.h>
#include <wchar.h>
#include <fstream>
#include <iostream>
#include <string>
#include <locale>

int main ()
{

  std::locale loc("");

  std::wifstream file_in;
  file_in.imbue(loc);
  std::wofstream file_out;
  file_out.imbue(loc);

  unsigned int Dec;
  FILE * pFile_In, * pFile_Out;

/**************************************************/

  pFile_In = fopen ("Hiragana_Dec.txt","r");

  pFile_Out = fopen ("Hiragana_Hex.txt","w");

  while (fscanf(pFile_In, "%d", &Dec) != EOF)
  {

  fprintf (pFile_Out, "%x\n", Dec);
  
  }

  fclose (pFile_In);
  
  fclose (pFile_Out);

/**************************************************/

  pFile_In = fopen ("Katakana_Dec.txt","r");

  pFile_Out = fopen ("Katakana_Hex.txt","w");

  while (fscanf(pFile_In, "%d", &Dec) != EOF)
  {

  fprintf (pFile_Out, "%x\n", Dec);
  
  }

  fclose (pFile_In);
  
  fclose (pFile_Out);

/**************************************************/

//This dumb shit doesn't work.

  wchar_t Hex;

  std::wstring line;

/**************************************************/

  //pFile_In = fopen ("Hiragana_Hex.txt","r");
  file_in.open("Hiragana_Hex.txt");

  //pFile_Out = fopen ("Hiragana_Uni.txt","w");
  file_out.open("Hiragana_Uni.txt",std::ios::out | std::ios::binary);

  //while (fscanf(pFile_In, "%d", &Hex) != EOF)
  while (! file_in.eof() )
  {
  
  getline (file_in,line);

  file_out<<"0x"<<line<<"\n";

  }

  //fclose (pFile_In);
  file_in.close();

  //fclose (pFile_Out);
  file_out.close();

/**************************************************/

  //pFile_In = fopen ("Katakana_Hex.txt","r");
  file_in.open("Katakana_Hex.txt");

  //pFile_Out = fopen ("Katakana_Uni.txt","w");
  file_out.open("Katakana_Uni.txt",std::ios::out | std::ios::binary);

  //while (fscanf(pFile_In, "%d", &Hex) != EOF)
  while (! file_in.eof() )
  {

  getline (file_in,line);

  file_out<<"0x"<<line<<"\n";

  }

  //fclose (pFile_In);
  file_in.close();

  //fclose (pFile_Out);
  file_out.close();

  return 0;
}
