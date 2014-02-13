Voice_Path=/usr/share/hts-voice/mei_normal

/usr/bin/open_jtalk -s 48000 -p 240 -a 0.55 \
  -td $Voice_Path/tree-dur.inf    -tm $Voice_Path/tree-mgc.inf    -tf $Voice_Path/tree-lf0.inf \
  -tl $Voice_Path/tree-lpf.inf    -md $Voice_Path/dur.pdf         -mm $Voice_Path/mgc.pdf \
  -mf $Voice_Path/lf0.pdf         -ml $Voice_Path/lpf.pdf         -dm $Voice_Path/mgc.win1 \
  -dm $Voice_Path/mgc.win2        -dm $Voice_Path/mgc.win3        -df $Voice_Path/lf0.win1 \
  -df $Voice_Path/lf0.win2        -df $Voice_Path/lf0.win3        -dl $Voice_Path/lpf.win1 \
  -em $Voice_Path/tree-gv-mgc.inf -ef $Voice_Path/tree-gv-lf0.inf -cm $Voice_Path/gv-mgc.pdf \
  -cf $Voice_Path/gv-lf0.pdf      -k  $Voice_Path/gv-switch.inf   -ow $2 \
  -x  /var/lib/mecab/dic/open-jtalk/naist-jdic $1

