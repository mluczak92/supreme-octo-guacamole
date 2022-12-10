namespace adventofcode2022._2022
{
    internal static class _07
    {
        //static string args = "$ cd /\r\n$ ls\r\ndir a\r\n14848514 b.txt\r\n8504156 c.dat\r\ndir d\r\n$ cd a\r\n$ ls\r\ndir e\r\n29116 f\r\n2557 g\r\n62596 h.lst\r\n$ cd e\r\n$ ls\r\n584 i\r\n$ cd ..\r\n$ cd ..\r\n$ cd d\r\n$ ls\r\n4060174 j\r\n8033020 d.log\r\n5626152 d.ext\r\n7214296 k";
        static string args = "$ cd /\r\n$ ls\r\ndir jmtrrrp\r\ndir jssnn\r\ndir lbrmb\r\n11968 pcccp\r\n$ cd jmtrrrp\r\n$ ls\r\n77968 chq.jvb\r\ndir fmgsql\r\n$ cd fmgsql\r\n$ ls\r\ndir dbnsfp\r\ndir vvp\r\n$ cd dbnsfp\r\n$ ls\r\n51021 crlq.lrj\r\n186829 dhcrzvbr.wmn\r\n16232 fvhn.fqm\r\n54150 qpbqqj.rpg\r\n$ cd ..\r\n$ cd vvp\r\n$ ls\r\n179105 rrcsndz.tzp\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd jssnn\r\n$ ls\r\ndir bphfqs\r\ndir dbnsfp\r\ndir pcccp\r\ndir snr\r\ndir zjbvwsnv\r\n$ cd bphfqs\r\n$ ls\r\n110077 dhcrzvbr.wmn\r\n$ cd ..\r\n$ cd dbnsfp\r\n$ ls\r\ndir hgvh\r\ndir jtqdcmsz\r\n154197 rrcsndz.tzp\r\n$ cd hgvh\r\n$ ls\r\ndir qjnbg\r\n$ cd qjnbg\r\n$ ls\r\ndir bqzfpr\r\n$ cd bqzfpr\r\n$ ls\r\n124394 wjsbsp\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd jtqdcmsz\r\n$ ls\r\n275597 dbnsfp.fpg\r\n$ cd ..\r\n$ cd ..\r\n$ cd pcccp\r\n$ ls\r\ndir cnbd\r\n85621 cqzvwl\r\ndir dbnsfp\r\n114355 hbhp.cfv\r\ndir mcgq\r\ndir pcccp\r\ndir qpbqqj\r\n224038 rrcsndz.tzp\r\ndir zcsm\r\n27570 zjbvwsnv.fjt\r\n$ cd cnbd\r\n$ ls\r\ndir jrbz\r\ndir pphv\r\n$ cd jrbz\r\n$ ls\r\ndir dwvlwfq\r\n$ cd dwvlwfq\r\n$ ls\r\n32237 fwclr.rnb\r\n$ cd ..\r\n$ cd ..\r\n$ cd pphv\r\n$ ls\r\n180370 dhcrzvbr.wmn\r\n50154 dzvwdwl.gbt\r\n123965 mlsv.hlw\r\n163116 wnhtwr.mwl\r\n$ cd ..\r\n$ cd ..\r\n$ cd dbnsfp\r\n$ ls\r\n252181 btv.mpv\r\ndir hwncj\r\ndir pcccp\r\n$ cd hwncj\r\n$ ls\r\n51410 jbd.fcm\r\n$ cd ..\r\n$ cd pcccp\r\n$ ls\r\n258123 chq.jvb\r\n$ cd ..\r\n$ cd ..\r\n$ cd mcgq\r\n$ ls\r\n206506 qpbqqj.bbb\r\n$ cd ..\r\n$ cd pcccp\r\n$ ls\r\n193219 ddhtnql.hmb\r\n134114 hjbpzqzb.rwn\r\n108927 lznndn.nqd\r\n73241 ncdrv\r\n$ cd ..\r\n$ cd qpbqqj\r\n$ ls\r\ndir crdt\r\ndir tgchdnc\r\n$ cd crdt\r\n$ ls\r\n205710 chq.jvb\r\n$ cd ..\r\n$ cd tgchdnc\r\n$ ls\r\ndir bdw\r\ndir dpl\r\ndir jssnn\r\ndir pcccp\r\ndir plpzbm\r\n$ cd bdw\r\n$ ls\r\n211300 dbnsfp.tjm\r\n$ cd ..\r\n$ cd dpl\r\n$ ls\r\n287744 rsbjqwm\r\n$ cd ..\r\n$ cd jssnn\r\n$ ls\r\ndir jssnn\r\n$ cd jssnn\r\n$ ls\r\n9644 hmjhshg.vbv\r\n$ cd ..\r\n$ cd ..\r\n$ cd pcccp\r\n$ ls\r\ndir jssnn\r\n85888 pcccp.hdj\r\ndir qpbqqj\r\ndir rmscmwtv\r\n$ cd jssnn\r\n$ ls\r\n129698 crlq.lrj\r\n7499 dhcrzvbr.wmn\r\n283607 qpbqqj.djr\r\n234874 wqnrhll\r\n$ cd ..\r\n$ cd qpbqqj\r\n$ ls\r\n184229 qqpb.ftd\r\n$ cd ..\r\n$ cd rmscmwtv\r\n$ ls\r\n188048 dhcrzvbr.wmn\r\ndir jwtpgbnt\r\n$ cd jwtpgbnt\r\n$ ls\r\n209946 hgg\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd plpzbm\r\n$ ls\r\n32627 tlb.qmc\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd zcsm\r\n$ ls\r\ndir lczflft\r\ndir zjbvwsnv\r\ndir zmh\r\n$ cd lczflft\r\n$ ls\r\n40043 dzgnvlw.scr\r\ndir lrnb\r\n$ cd lrnb\r\n$ ls\r\n109881 bjpbs\r\ndir jssnn\r\n46901 npmw\r\n$ cd jssnn\r\n$ ls\r\n9216 sgrp\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd zjbvwsnv\r\n$ ls\r\n214676 jssnn.hgn\r\n$ cd ..\r\n$ cd zmh\r\n$ ls\r\ndir jdt\r\ndir rggpltr\r\n$ cd jdt\r\n$ ls\r\n147387 jhhsv\r\n90052 jssnn.wns\r\n53105 qpbqqj.dzq\r\n$ cd ..\r\n$ cd rggpltr\r\n$ ls\r\n121454 dbnsfp.dzt\r\ndir gcc\r\n$ cd gcc\r\n$ ls\r\ndir zbqwl\r\ndir zjbvwsnv\r\n$ cd zbqwl\r\n$ ls\r\n260297 pcccp.jrw\r\n$ cd ..\r\n$ cd zjbvwsnv\r\n$ ls\r\n248709 pcccp.tph\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd snr\r\n$ ls\r\n152569 chq.jvb\r\n1437 crlq.lrj\r\n$ cd ..\r\n$ cd zjbvwsnv\r\n$ ls\r\ndir cqhb\r\n53235 ghhtl.bhv\r\n199640 npcfdw\r\n136346 qpbqqj.lmv\r\ndir zjbvwsnv\r\n$ cd cqhb\r\n$ ls\r\n24712 sqqf\r\n$ cd ..\r\n$ cd zjbvwsnv\r\n$ ls\r\ndir gzqg\r\ndir hfbfvn\r\ndir srsphr\r\ndir vgvdcvc\r\n$ cd gzqg\r\n$ ls\r\ndir jjw\r\n$ cd jjw\r\n$ ls\r\n240052 zdcjjz.pmg\r\n$ cd ..\r\n$ cd ..\r\n$ cd hfbfvn\r\n$ ls\r\n278190 bfgndw.pvf\r\n$ cd ..\r\n$ cd srsphr\r\n$ ls\r\n42591 zjbvwsnv.hgh\r\n$ cd ..\r\n$ cd vgvdcvc\r\n$ ls\r\n120322 rrcsndz.tzp\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd lbrmb\r\n$ ls\r\ndir bjhpdj\r\n42241 crlq.lrj\r\ndir dbnsfp\r\n244610 dhcrzvbr.wmn\r\ndir hppb\r\ndir mcnzs\r\ndir npntsr\r\n13625 tpjpcsgp.dlz\r\n219424 vvpbt.zvf\r\ndir zjbvwsnv\r\n191467 zjbvwsnv.htn\r\n$ cd bjhpdj\r\n$ ls\r\ndir bqjvst\r\n204722 dbnsfp\r\ndir dhltrqqq\r\n226082 dmdqcjp\r\ndir fcqwgzp\r\ndir jssnn\r\n6453 jssnn.ndh\r\n23799 jssnn.zqn\r\ndir nwglfhpl\r\ndir pcccp\r\ndir pdnj\r\n269246 shzqns.nws\r\ndir sjstqlcb\r\ndir zssln\r\n$ cd bqjvst\r\n$ ls\r\n202793 dbnsfp.pjj\r\n259783 jssnn\r\ndir rbvbhnvs\r\n30683 rvddnjmb.tlz\r\ndir tzhslnv\r\n$ cd rbvbhnvs\r\n$ ls\r\n86934 vrtrf.htt\r\n$ cd ..\r\n$ cd tzhslnv\r\n$ ls\r\n76278 mghcwdlr.tsc\r\n$ cd ..\r\n$ cd ..\r\n$ cd dhltrqqq\r\n$ ls\r\ndir mfd\r\ndir pcccp\r\ndir smmb\r\n251164 wsdnsgtt.lhr\r\n191876 zvr.bbz\r\n$ cd mfd\r\n$ ls\r\n51017 crlq.lrj\r\n99213 rjtbnnnq.hgd\r\n$ cd ..\r\n$ cd pcccp\r\n$ ls\r\n160487 dhcrzvbr.wmn\r\ndir nhdrnthj\r\ndir qpbqqj\r\n$ cd nhdrnthj\r\n$ ls\r\n181291 bbn.wtm\r\n186551 fnw.tnn\r\n23622 rrcsndz.tzp\r\ndir zjbvwsnv\r\n$ cd zjbvwsnv\r\n$ ls\r\n227547 dhcrzvbr.wmn\r\n$ cd ..\r\n$ cd ..\r\n$ cd qpbqqj\r\n$ ls\r\n212353 crlq.lrj\r\n170195 dhcrzvbr.wmn\r\ndir ttvp\r\n$ cd ttvp\r\n$ ls\r\n185994 tgjcfgjv\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd smmb\r\n$ ls\r\ndir dbnsfp\r\n85354 dbnsfp.zpn\r\n80665 dfmmjbm.rnr\r\n135989 dhcrzvbr.wmn\r\n93718 lrbzr.nfs\r\ndir mjpfnfns\r\ndir nsdpfnhb\r\ndir pmnssvd\r\n32270 qpbqqj.vtd\r\n$ cd dbnsfp\r\n$ ls\r\n31796 gzs.rgv\r\n64506 vbjncw.bpz\r\n181659 vjlfrdp.tqh\r\n$ cd ..\r\n$ cd mjpfnfns\r\n$ ls\r\n231611 chq.jvb\r\n17518 cmnlrzq.hvh\r\n144795 dbnsfp\r\n162194 jssnn.wjz\r\n29305 vdqnlw.fzf\r\n$ cd ..\r\n$ cd nsdpfnhb\r\n$ ls\r\n281844 chq.jvb\r\n$ cd ..\r\n$ cd pmnssvd\r\n$ ls\r\n165816 dfvl.czb\r\n144561 gbn\r\n150785 lnzdwrmb\r\n111214 rrcsndz.tzp\r\n164156 tzgdb.hht\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd fcqwgzp\r\n$ ls\r\n199161 dhcrzvbr.wmn\r\n34251 rrcsndz.tzp\r\n198345 vjlfrdp.tqh\r\n167001 zjbvwsnv.bsd\r\n$ cd ..\r\n$ cd jssnn\r\n$ ls\r\ndir ccblfvl\r\n103180 dhcrzvbr.wmn\r\ndir prw\r\ndir tzqfn\r\ndir zjbvwsnv\r\n166467 zjbvwsnv.tdt\r\n$ cd ccblfvl\r\n$ ls\r\n159752 crlq.lrj\r\n20805 jssnn.dvb\r\n243040 lct.zll\r\n27492 qbh\r\n27174 vjlfrdp.tqh\r\ndir zvfwq\r\n$ cd zvfwq\r\n$ ls\r\n135126 chq.jvb\r\n41664 gphw.vzd\r\ndir hmrdghbr\r\ndir jssnn\r\ndir qzzb\r\ndir tmdlcv\r\n$ cd hmrdghbr\r\n$ ls\r\ndir jvgpwrbs\r\n$ cd jvgpwrbs\r\n$ ls\r\ndir wzdv\r\n$ cd wzdv\r\n$ ls\r\n26834 qpbqqj.njf\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd jssnn\r\n$ ls\r\n90199 jqqmqddf.qnz\r\n$ cd ..\r\n$ cd qzzb\r\n$ ls\r\ndir mgpql\r\ndir src\r\ndir zvdgc\r\n$ cd mgpql\r\n$ ls\r\n141852 qpbqqj\r\n$ cd ..\r\n$ cd src\r\n$ ls\r\n204425 lqmcbndm.jrj\r\n75571 qsbrsv.jcm\r\n$ cd ..\r\n$ cd zvdgc\r\n$ ls\r\n268742 ffjmrmmz.lhg\r\n18385 rvmp.hjv\r\n$ cd ..\r\n$ cd ..\r\n$ cd tmdlcv\r\n$ ls\r\n182587 sfwvjrj.mzl\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd prw\r\n$ ls\r\n207429 dbnsfp.rqf\r\ndir ptgn\r\ndir pzgpqp\r\n252902 rbt\r\n169694 trg.rsh\r\n$ cd ptgn\r\n$ ls\r\ndir jssnn\r\ndir qpbqqj\r\ndir rpd\r\n$ cd jssnn\r\n$ ls\r\n189316 dbnsfp.bqc\r\n$ cd ..\r\n$ cd qpbqqj\r\n$ ls\r\n167937 zjbvwsnv.bhz\r\n$ cd ..\r\n$ cd rpd\r\n$ ls\r\n8775 crlq.lrj\r\n$ cd ..\r\n$ cd ..\r\n$ cd pzgpqp\r\n$ ls\r\ndir pcccp\r\n$ cd pcccp\r\n$ ls\r\n51496 pcccp\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd tzqfn\r\n$ ls\r\ndir cbpfvdp\r\n285700 crlq.lrj\r\n7426 dbnsfp.fsd\r\ndir gdl\r\n141367 jssnn.hmw\r\n184482 sczphnp.vnc\r\n126288 vjlfrdp.tqh\r\ndir wndpdj\r\n$ cd cbpfvdp\r\n$ ls\r\ndir cvfr\r\ndir qpbqqj\r\n$ cd cvfr\r\n$ ls\r\ndir jfrnvts\r\ndir qpbqqj\r\n$ cd jfrnvts\r\n$ ls\r\ndir vwdn\r\n$ cd vwdn\r\n$ ls\r\n236936 vjlfrdp.tqh\r\n$ cd ..\r\n$ cd ..\r\n$ cd qpbqqj\r\n$ ls\r\n254275 bqd\r\n$ cd ..\r\n$ cd ..\r\n$ cd qpbqqj\r\n$ ls\r\ndir jssnn\r\n201960 qpbqqj\r\n$ cd jssnn\r\n$ ls\r\n131127 jssnn\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd gdl\r\n$ ls\r\n225146 hsgzmtp.wcs\r\n204436 jssnn.lhh\r\n64007 mjzjgfg.jsb\r\n$ cd ..\r\n$ cd wndpdj\r\n$ ls\r\n245412 bvcq\r\n211386 dbnsfp.tqd\r\n186962 fql.mww\r\ndir hlmhtfz\r\n117446 smvjvcn.lcp\r\n$ cd hlmhtfz\r\n$ ls\r\n150152 lrdhbq.rvm\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd zjbvwsnv\r\n$ ls\r\n179703 fvmbz\r\n87552 qtz.ccw\r\n129764 rrcsndz.tzp\r\n$ cd ..\r\n$ cd ..\r\n$ cd nwglfhpl\r\n$ ls\r\n66039 crlq.lrj\r\ndir cwq\r\ndir dlgrsw\r\n267814 frhlttn.nmd\r\ndir hmprt\r\ndir qpbqqj\r\ndir wnfzznfh\r\n$ cd cwq\r\n$ ls\r\n77655 cpjnwzh\r\ndir pcccp\r\ndir zjbvwsnv\r\ndir zzhjfmnr\r\n$ cd pcccp\r\n$ ls\r\ndir pcccp\r\n$ cd pcccp\r\n$ ls\r\n245309 bggzbrg.flf\r\n$ cd ..\r\n$ cd ..\r\n$ cd zjbvwsnv\r\n$ ls\r\n196915 gnmfb.dzq\r\ndir ngqbdqp\r\n$ cd ngqbdqp\r\n$ ls\r\n355 rrcsndz.tzp\r\n$ cd ..\r\n$ cd ..\r\n$ cd zzhjfmnr\r\n$ ls\r\ndir dbnsfp\r\n$ cd dbnsfp\r\n$ ls\r\n223184 chq.jvb\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd dlgrsw\r\n$ ls\r\n181906 chq.jvb\r\n5636 dbnsfp\r\n219889 jbr.slc\r\ndir zrntbl\r\n$ cd zrntbl\r\n$ ls\r\n61864 brnpgpwt\r\n138980 qpbqqj\r\n$ cd ..\r\n$ cd ..\r\n$ cd hmprt\r\n$ ls\r\n90249 dbnsfp.mbd\r\n$ cd ..\r\n$ cd qpbqqj\r\n$ ls\r\n290377 crlq.lrj\r\n$ cd ..\r\n$ cd wnfzznfh\r\n$ ls\r\n83022 hclmps\r\n64095 zhm\r\n$ cd ..\r\n$ cd ..\r\n$ cd pcccp\r\n$ ls\r\ndir rdzntr\r\ndir rvccq\r\n$ cd rdzntr\r\n$ ls\r\n239028 rrcsndz.tzp\r\n$ cd ..\r\n$ cd rvccq\r\n$ ls\r\n22746 chq.jvb\r\n288752 jjvppq.swt\r\ndir msgwsnjq\r\ndir pggz\r\n228469 vjlfrdp.tqh\r\n$ cd msgwsnjq\r\n$ ls\r\n102522 lwgqc.mhv\r\n25239 ndm.llf\r\n$ cd ..\r\n$ cd pggz\r\n$ ls\r\ndir cnjqsqj\r\n$ cd cnjqsqj\r\n$ ls\r\n229407 shpnq\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd pdnj\r\n$ ls\r\n193069 rwnhgttz.pvp\r\n$ cd ..\r\n$ cd sjstqlcb\r\n$ ls\r\n263295 chq.jvb\r\n224091 jss.wtr\r\n$ cd ..\r\n$ cd zssln\r\n$ ls\r\n5859 ncdlcr.dll\r\n$ cd ..\r\n$ cd ..\r\n$ cd dbnsfp\r\n$ ls\r\n271252 dhcrzvbr.wmn\r\n$ cd ..\r\n$ cd hppb\r\n$ ls\r\n259968 jssnn\r\n81292 qpqqb.clj\r\n$ cd ..\r\n$ cd mcnzs\r\n$ ls\r\n170903 crlq.lrj\r\n59482 dhcrzvbr.wmn\r\ndir dqzwzbgm\r\ndir gnrztn\r\n286736 jssnn.jcm\r\n32791 phqsgl\r\ndir pzjnrwt\r\n197323 vjlfrdp.tqh\r\ndir wvnwbpct\r\n$ cd dqzwzbgm\r\n$ ls\r\n78575 qpbqqj\r\n251546 qpbqqj.slb\r\n$ cd ..\r\n$ cd gnrztn\r\n$ ls\r\n158603 hdnwmd.rhj\r\ndir nbfdtwzr\r\n178239 ptnchzpg\r\n40517 rrcsndz.tzp\r\ndir smvb\r\n198007 vjlfrdp.tqh\r\n$ cd nbfdtwzr\r\n$ ls\r\n200354 crlq.lrj\r\n$ cd ..\r\n$ cd smvb\r\n$ ls\r\n163921 zjbvwsnv.brz\r\n$ cd ..\r\n$ cd ..\r\n$ cd pzjnrwt\r\n$ ls\r\n33891 lwrll\r\n259646 pcccp.sfn\r\n106835 pqfzthjq\r\n189673 rrcsndz.tzp\r\n$ cd ..\r\n$ cd wvnwbpct\r\n$ ls\r\n234188 dhcrzvbr.wmn\r\ndir gmtpsgv\r\n86379 jssnn\r\n146663 sfpmdbbd.jvt\r\n25795 vjlfrdp.tqh\r\n$ cd gmtpsgv\r\n$ ls\r\n18642 chq.jvb\r\n3046 cznlwtw\r\n26335 ddgpngrc\r\n116455 vnnls.hsg\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd npntsr\r\n$ ls\r\ndir cccjdcvb\r\n206657 chq.jvb\r\n280518 crlq.lrj\r\ndir dbnsfp\r\ndir jphnn\r\ndir jssnn\r\ndir mpl\r\n195193 rrcsndz.tzp\r\ndir rztc\r\ndir znwp\r\n$ cd cccjdcvb\r\n$ ls\r\n192965 mcr.sfq\r\n$ cd ..\r\n$ cd dbnsfp\r\n$ ls\r\ndir gfns\r\n173317 jssnn.tjq\r\ndir mgr\r\n68817 mvwcwfcr.zmz\r\ndir pqfht\r\n108571 swfl.dtj\r\n10398 tvvvv\r\ndir vzg\r\n174361 zjbvwsnv\r\n$ cd gfns\r\n$ ls\r\n203999 zjbvwsnv.hfg\r\n$ cd ..\r\n$ cd mgr\r\n$ ls\r\ndir zjbvwsnv\r\n$ cd zjbvwsnv\r\n$ ls\r\n26871 tqlgcf.jrn\r\n$ cd ..\r\n$ cd ..\r\n$ cd pqfht\r\n$ ls\r\n199590 clpvscl.rlm\r\ndir dwlhv\r\ndir vhzfzhrb\r\n$ cd dwlhv\r\n$ ls\r\n130761 qpbqqj\r\n242752 rrcsndz.tzp\r\n$ cd ..\r\n$ cd vhzfzhrb\r\n$ ls\r\ndir njdgcbvm\r\n$ cd njdgcbvm\r\n$ ls\r\ndir snjfqg\r\n$ cd snjfqg\r\n$ ls\r\ndir qpwh\r\n$ cd qpwh\r\n$ ls\r\n153353 qsjpj\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd vzg\r\n$ ls\r\ndir pcccp\r\n$ cd pcccp\r\n$ ls\r\ndir jfbtl\r\n$ cd jfbtl\r\n$ ls\r\n209199 dbnsfp\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd jphnn\r\n$ ls\r\n52305 crlq.lrj\r\n193480 gmms.whz\r\n59354 nmq.dww\r\n64638 qpbqqj\r\n47072 rrcsndz.tzp\r\n$ cd ..\r\n$ cd jssnn\r\n$ ls\r\n69168 crlq.lrj\r\n1549 dhcrzvbr.wmn\r\n219596 hdmczg.lmm\r\n108063 jssnn\r\n24327 vjlfrdp.tqh\r\ndir zjbvwsnv\r\n$ cd zjbvwsnv\r\n$ ls\r\n189952 chq.jvb\r\n$ cd ..\r\n$ cd ..\r\n$ cd mpl\r\n$ ls\r\n144856 bqrrzm\r\n249487 crlq.lrj\r\ndir ffqgpgfg\r\n93632 flqwtn.nsz\r\ndir mwpcqr\r\n195910 pdqwn.lcg\r\n$ cd ffqgpgfg\r\n$ ls\r\n66459 dbnsfp\r\n200500 lcmt.zmz\r\n207093 qpbqqj\r\n77042 vjlfrdp.tqh\r\n57109 wwzv.hbn\r\n$ cd ..\r\n$ cd mwpcqr\r\n$ ls\r\ndir zjbvwsnv\r\n$ cd zjbvwsnv\r\n$ ls\r\n166393 vjlfrdp.tqh\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd rztc\r\n$ ls\r\n57788 chq.jvb\r\n$ cd ..\r\n$ cd znwp\r\n$ ls\r\n164627 chq.jvb\r\n$ cd ..\r\n$ cd ..\r\n$ cd zjbvwsnv\r\n$ ls\r\ndir dgrrl\r\n71529 jssnn\r\n198617 pcccp.qqh\r\ndir phggn\r\n56842 zjbvwsnv.vqd\r\n$ cd dgrrl\r\n$ ls\r\ndir czm\r\ndir fhhlbdlz\r\ndir gstjw\r\ndir qpbqqj\r\ndir stgb\r\n$ cd czm\r\n$ ls\r\ndir jssnn\r\n$ cd jssnn\r\n$ ls\r\n162335 chq.jvb\r\n30099 mfdgdw\r\n96389 pcdsd.wmw\r\n251423 tmz.lcb\r\n205979 vpltdt.gtv\r\n$ cd ..\r\n$ cd ..\r\n$ cd fhhlbdlz\r\n$ ls\r\ndir qpbqqj\r\ndir vdjs\r\ndir zgz\r\n$ cd qpbqqj\r\n$ ls\r\n285561 chq.jvb\r\n263924 lbqcfdrs\r\n138854 pcccp.dtn\r\n$ cd ..\r\n$ cd vdjs\r\n$ ls\r\n32688 chq.jvb\r\n223233 tbn.blt\r\n$ cd ..\r\n$ cd zgz\r\n$ ls\r\n92804 bqltmv.wzb\r\n$ cd ..\r\n$ cd ..\r\n$ cd gstjw\r\n$ ls\r\n151784 fvfszzzn.cbh\r\n$ cd ..\r\n$ cd qpbqqj\r\n$ ls\r\ndir blztqf\r\ndir plgnh\r\n$ cd blztqf\r\n$ ls\r\n195097 wlvmtz\r\n$ cd ..\r\n$ cd plgnh\r\n$ ls\r\ndir dbnsfp\r\n246221 dhcrzvbr.wmn\r\n271121 jhwmmzls.mhw\r\n170162 pcccp.dpp\r\n37872 qpbqqj\r\n$ cd dbnsfp\r\n$ ls\r\ndir dhpnr\r\n$ cd dhpnr\r\n$ ls\r\n152837 pcccp\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd stgb\r\n$ ls\r\n248436 vjlfrdp.tqh\r\n$ cd ..\r\n$ cd ..\r\n$ cd phggn\r\n$ ls\r\n284602 dhcrzvbr.wmn\r\ndir lctr\r\ndir rjmc\r\n66651 rrcsndz.tzp\r\n117525 vth.fgw\r\n156877 wcqnjzbq.dgf\r\n7803 zpsrzclh.bzw\r\n$ cd lctr\r\n$ ls\r\n212339 jssnn.whp\r\ndir jzhcqb\r\n99974 pcccp.zhs\r\n111354 pmc\r\n104899 vjlfrdp.tqh\r\n93496 zhwmbw\r\n$ cd jzhcqb\r\n$ ls\r\ndir zjbvwsnv\r\n$ cd zjbvwsnv\r\n$ ls\r\n146807 rbrg\r\n$ cd ..\r\n$ cd ..\r\n$ cd ..\r\n$ cd rjmc\r\n$ ls\r\ndir fvbmsc\r\n139747 glwmr.lrg\r\ndir gvnnz\r\n102023 tbj.qmz\r\ndir vsztsjfh\r\n$ cd fvbmsc\r\n$ ls\r\n136838 vpvbz.qtw\r\n$ cd ..\r\n$ cd gvnnz\r\n$ ls\r\n95498 zjbvwsnv\r\n$ cd ..\r\n$ cd vsztsjfh\r\n$ ls\r\n215479 ffwlcrwb";

        class Folder : Node
        {
            public Folder(Folder? parent, string name) : base(parent, name)
            {

            }

            public override int Size => Children.Sum(x => x.Size);
            public List<Node> Children { get; } = new List<Node>();
        }

        class File : Node
        {
            public File(Folder parent, string name, int size) : base(parent, name)
            {
                Size = size;
            }

            public override int Size { get; }
        }

        abstract class Node
        {
            public Node(Folder? parent, string name)
            {
                Parent = parent;
                Name = name;
            }

            public Folder? Parent { get; }
            public string Name { get; }
            public abstract int Size { get; }
        }

        public static void Run()
        {
            Folder currentNode = new Folder(null, "/");

            var cmds = args.Split("\r\n")
                .Skip(1)
                .Select(x => x.Split(" "));

            foreach (var cmd in cmds)
            {
                if (cmd[1] == "cd")
                {
                    if (cmd[2] == "..")
                    {
                        currentNode = currentNode.Parent!;
                    }
                    else
                    {
                        currentNode = currentNode.Children.OfType<Folder>().Single(x => x.Name == cmd[2]);
                    }
                }
                else if (cmd[1] != "ls")
                {
                    if (cmd[0] == "dir")
                    {
                        var newNode = new Folder(currentNode, cmd[1]);
                        currentNode.Children.Add(newNode);
                    }
                    else
                    {
                        var newNode = new File(currentNode, cmd[1], int.Parse(cmd[0]));
                        currentNode.Children.Add(newNode);
                    }
                }
            }

            while (currentNode.Parent != null)
            {
                currentNode = currentNode.Parent;
            }

            int sum = 0;
            AddSizeIfLowerThan100000(currentNode, ref sum);
            Console.WriteLine(sum);

            int toFree = 30000000 - (70000000 - currentNode.Size);
            int smallestToFree = int.MaxValue;
            GetSmallestSizeToFree(currentNode, toFree, ref smallestToFree);
            Console.WriteLine(smallestToFree);
        }

        static void AddSizeIfLowerThan100000(Folder node, ref int sum)
        {
            foreach (Folder child in node.Children.OfType<Folder>())
            {
                AddSizeIfLowerThan100000(child, ref sum);
            }

            if (node.Size <= 100000)
            {
                sum += node.Size;
            }
        }

        static void GetSmallestSizeToFree(Folder node, int toFree, ref int smallestToFree)
        {
            foreach (Folder child in node.Children.OfType<Folder>())
            {
                GetSmallestSizeToFree(child, toFree, ref smallestToFree);
            }

            if (node.Size >= toFree && node.Size < smallestToFree)
            {
                smallestToFree = node.Size;
            }
        }
    }
}
