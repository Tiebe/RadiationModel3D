using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neodymium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium141";
        public override double halfLife { get; } = 8964.0d;
        public override double atomicWeight { get; } = 140.90962d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cerium141()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0024d, new GammaParticle(145450.0, 0.00852)), new(0.00021799999999999999d, new GammaParticle(981700.0, 0.00126)), new(0.00796d, new GammaParticle(1126910.0, 0.0011)), new(0.00307d, new GammaParticle(1147300.0, 0.00108)), new(9.8e-05d, new GammaParticle(1289580.0, 0.00096)), new(0.0046d, new GammaParticle(1292640.0, 0.00096)), new(0.00127d, new GammaParticle(1298600.0, 0.00095)), new(3.2000000000000003e-06d, new GammaParticle(1306000.0, 0.00095)), new(4e-06d, new GammaParticle(1310600.0, 0.00095)), new(5.6e-05d, new GammaParticle(1434600.0, 0.00086)), new(8e-06d, new GammaParticle(1435100.0, 0.00086)), new(8e-06d, new GammaParticle(1456120.0, 0.00085)), new(6.1000000000000005e-05d, new GammaParticle(1580170.0, 0.00078)), new(0.000184d, new GammaParticle(1608350.0, 0.00077)), new(9.6e-06d, new GammaParticle(1657040.0, 0.00075)), new(0.0518d, new GammaParticle(511000.0, 0.00243)), new(0.11027901755966774d, new GammaParticle(5637.0, 0.21995)), new(0.21378215681547152d, new GammaParticle(35551.0, 0.03488)), new(0.390398387172154d, new GammaParticle(36027.0, 0.03441)), new(0.11876765629820443d, new GammaParticle(40857.0, 0.03035)), new(0.14917217631054477d, new GammaParticle(41266.0, 0.03005)), new(0.030404520012340334d, new GammaParticle(41766.0, 0.02969)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 2000.0d, 0.00000000145452d },
            { 4000.0d, 0.00000000694832d },
            { 6000.0d, 0.0000000195063d },
            { 8000.0d, 0.0000000421536d },
            { 10000.0d, 0.0000000776918d },
            { 12000.0d, 0.00000012857d },
            { 14000.0d, 0.000000196831d },
            { 16000.0d, 0.000000284109d },
            { 18000.0d, 0.000000391647d },
            { 20000.0d, 0.000000520334d },
            { 22000.0d, 0.000000670746d },
            { 24000.0d, 0.000000843189d },
            { 26000.0d, 0.00000103774d },
            { 28000.0d, 0.00000125428d },
            { 30000.0d, 0.00000149254d },
            { 32000.0d, 0.0000017521d },
            { 34000.0d, 0.00000203247d },
            { 36000.0d, 0.00000233305d },
            { 38000.0d, 0.00000265319d },
            { 40000.0d, 0.00000299218d },
            { 42000.0d, 0.0000033493d },
            { 44000.0d, 0.00000372377d },
            { 46000.0d, 0.00000411483d },
            { 48000.0d, 0.0000045217d },
            { 50000.0d, 0.00000494359d },
            { 52000.0d, 0.00000537975d },
            { 54000.0d, 0.00000582939d },
            { 56000.0d, 0.00000629177d },
            { 58000.0d, 0.00000676614d },
            { 60000.0d, 0.0000072518d },
            { 62000.0d, 0.00000774803d },
            { 64000.0d, 0.00000825416d },
            { 66000.0d, 0.00000876951d },
            { 68000.0d, 0.00000929345d },
            { 70000.0d, 0.00000982536d },
            { 72000.0d, 0.0000103646d },
            { 74000.0d, 0.0000109107d },
            { 76000.0d, 0.000011463d },
            { 78000.0d, 0.000012021d },
            { 80000.0d, 0.0000125841d },
            { 82000.0d, 0.000013152d },
            { 84000.0d, 0.000013724d },
            { 86000.0d, 0.0000142998d },
            { 88000.0d, 0.0000148789d },
            { 90000.0d, 0.0000154609d },
            { 92000.0d, 0.0000160453d },
            { 94000.0d, 0.0000166318d },
            { 96000.0d, 0.00001722d },
            { 98000.0d, 0.0000178095d },
            { 100000.0d, 0.0000184001d },
            { 102000.0d, 0.0000189913d },
            { 104000.0d, 0.0000195829d },
            { 106000.0d, 0.0000201745d },
            { 108000.0d, 0.0000207658d },
            { 110000.0d, 0.0000213567d },
            { 112000.0d, 0.0000219468d },
            { 114000.0d, 0.0000225358d },
            { 116000.0d, 0.0000231235d },
            { 118000.0d, 0.0000237097d },
            { 120000.0d, 0.0000242941d },
            { 122000.0d, 0.0000248766d },
            { 124000.0d, 0.0000254569d },
            { 126000.0d, 0.0000260349d },
            { 128000.0d, 0.0000266102d },
            { 130000.0d, 0.0000271829d },
            { 132000.0d, 0.0000277526d },
            { 134000.0d, 0.0000283192d },
            { 136000.0d, 0.0000288826d },
            { 138000.0d, 0.0000294426d },
            { 140000.0d, 0.0000299991d },
            { 142000.0d, 0.0000305518d },
            { 144000.0d, 0.0000311008d },
            { 146000.0d, 0.0000316458d },
            { 148000.0d, 0.0000321868d },
            { 150000.0d, 0.0000327235d },
            { 152000.0d, 0.000033256d },
            { 154000.0d, 0.0000337841d },
            { 156000.0d, 0.0000343076d },
            { 158000.0d, 0.0000348266d },
            { 160000.0d, 0.0000353409d },
            { 162000.0d, 0.0000358504d },
            { 164000.0d, 0.000036355d },
            { 166000.0d, 0.0000368547d },
            { 168000.0d, 0.0000373493d },
            { 170000.0d, 0.0000378389d },
            { 172000.0d, 0.0000383232d },
            { 174000.0d, 0.0000388023d },
            { 176000.0d, 0.0000392762d },
            { 178000.0d, 0.0000397446d },
            { 180000.0d, 0.0000402077d },
            { 182000.0d, 0.0000406652d },
            { 184000.0d, 0.0000411173d },
            { 186000.0d, 0.0000415637d },
            { 188000.0d, 0.0000420045d },
            { 190000.0d, 0.0000424397d },
            { 192000.0d, 0.0000428691d },
            { 194000.0d, 0.0000432928d },
            { 196000.0d, 0.0000437107d },
            { 198000.0d, 0.0000441228d },
            { 200000.0d, 0.000044529d },
            { 202000.0d, 0.0000449293d },
            { 204000.0d, 0.0000453237d },
            { 206000.0d, 0.0000457122d },
            { 208000.0d, 0.0000460946d },
            { 210000.0d, 0.0000464711d },
            { 212000.0d, 0.0000468416d },
            { 214000.0d, 0.000047206d },
            { 216000.0d, 0.0000475644d },
            { 218000.0d, 0.0000479167d },
            { 220000.0d, 0.0000482629d },
            { 222000.0d, 0.0000486029d },
            { 224000.0d, 0.0000489369d },
            { 226000.0d, 0.0000492647d },
            { 228000.0d, 0.0000495864d },
            { 230000.0d, 0.000049902d },
            { 232000.0d, 0.0000502113d },
            { 234000.0d, 0.0000505146d },
            { 236000.0d, 0.0000508116d },
            { 238000.0d, 0.0000511025d },
            { 240000.0d, 0.0000513871d },
            { 242000.0d, 0.0000516656d },
            { 244000.0d, 0.0000519379d },
            { 246000.0d, 0.0000522041d },
            { 248000.0d, 0.000052464d },
            { 250000.0d, 0.0000527178d },
            { 252000.0d, 0.0000529654d },
            { 254000.0d, 0.0000532068d },
            { 256000.0d, 0.000053442d },
            { 258000.0d, 0.0000536711d },
            { 260000.0d, 0.000053894d },
            { 262000.0d, 0.0000541108d },
            { 264000.0d, 0.0000543214d },
            { 266000.0d, 0.0000545259d },
            { 268000.0d, 0.0000547242d },
            { 270000.0d, 0.0000549164d },
            { 272000.0d, 0.0000551026d },
            { 274000.0d, 0.0000552826d },
            { 276000.0d, 0.0000554566d },
            { 278000.0d, 0.0000556244d },
            { 280000.0d, 0.0000557862d },
            { 282000.0d, 0.000055942d },
            { 284000.0d, 0.0000560918d },
            { 286000.0d, 0.0000562355d },
            { 288000.0d, 0.0000563732d },
            { 290000.0d, 0.000056505d },
            { 292000.0d, 0.0000566308d },
            { 294000.0d, 0.0000567506d },
            { 296000.0d, 0.0000568645d },
            { 298000.0d, 0.0000569725d },
            { 300000.0d, 0.0000570746d },
            { 302000.0d, 0.0000571709d },
            { 304000.0d, 0.0000572613d },
            { 306000.0d, 0.0000573458d },
            { 308000.0d, 0.0000574246d },
            { 310000.0d, 0.0000574976d },
            { 312000.0d, 0.0000575648d },
            { 314000.0d, 0.0000576262d },
            { 316000.0d, 0.0000576819d },
            { 318000.0d, 0.000057732d },
            { 320000.0d, 0.0000577763d },
            { 322000.0d, 0.0000578151d },
            { 324000.0d, 0.0000578482d },
            { 326000.0d, 0.0000578757d },
            { 328000.0d, 0.0000578976d },
            { 330000.0d, 0.000057914d },
            { 332000.0d, 0.0000579248d },
            { 334000.0d, 0.0000579302d },
            { 336000.0d, 0.0000579301d },
            { 338000.0d, 0.0000579245d },
            { 340000.0d, 0.0000579136d },
            { 342000.0d, 0.0000578973d },
            { 344000.0d, 0.0000578756d },
            { 346000.0d, 0.0000578486d },
            { 348000.0d, 0.0000578162d },
            { 350000.0d, 0.0000577787d },
            { 352000.0d, 0.0000577359d },
            { 354000.0d, 0.0000576878d },
            { 356000.0d, 0.0000576347d },
            { 358000.0d, 0.0000575763d },
            { 360000.0d, 0.0000575129d },
            { 362000.0d, 0.0000574443d },
            { 364000.0d, 0.0000573708d },
            { 366000.0d, 0.0000572922d },
            { 368000.0d, 0.0000572086d },
            { 370000.0d, 0.0000571201d },
            { 372000.0d, 0.0000570266d },
            { 374000.0d, 0.0000569283d },
            { 376000.0d, 0.0000568251d },
            { 378000.0d, 0.0000567171d },
            { 380000.0d, 0.0000566043d },
            { 382000.0d, 0.0000564868d },
            { 384000.0d, 0.0000563645d },
            { 386000.0d, 0.0000562376d },
            { 388000.0d, 0.0000561061d },
            { 390000.0d, 0.0000559699d },
            { 392000.0d, 0.0000558291d },
            { 394000.0d, 0.0000556839d },
            { 396000.0d, 0.0000555341d },
            { 398000.0d, 0.0000553799d },
            { 400000.0d, 0.0000552212d },
            { 402000.0d, 0.0000550582d },
            { 404000.0d, 0.0000548908d },
            { 406000.0d, 0.0000547191d },
            { 408000.0d, 0.0000545432d },
            { 410000.0d, 0.000054363d },
            { 412000.0d, 0.0000541786d },
            { 414000.0d, 0.00005399d },
            { 416000.0d, 0.0000537974d },
            { 418000.0d, 0.0000536006d },
            { 420000.0d, 0.0000533999d },
            { 422000.0d, 0.0000531951d },
            { 424000.0d, 0.0000529864d },
            { 426000.0d, 0.0000527737d },
            { 428000.0d, 0.0000525572d },
            { 430000.0d, 0.0000523368d },
            { 432000.0d, 0.0000521127d },
            { 434000.0d, 0.0000518848d },
            { 436000.0d, 0.0000516532d },
            { 438000.0d, 0.0000514179d },
            { 440000.0d, 0.000051179d },
            { 442000.0d, 0.0000509365d },
            { 444000.0d, 0.0000506905d },
            { 446000.0d, 0.0000504409d },
            { 448000.0d, 0.0000501879d },
            { 450000.0d, 0.0000499315d },
            { 452000.0d, 0.0000496718d },
            { 454000.0d, 0.0000494087d },
            { 456000.0d, 0.0000491423d },
            { 458000.0d, 0.0000488727d },
            { 460000.0d, 0.0000485999d },
            { 462000.0d, 0.0000483239d },
            { 464000.0d, 0.0000480449d },
            { 466000.0d, 0.0000477627d },
            { 468000.0d, 0.0000474776d },
            { 470000.0d, 0.0000471895d },
            { 472000.0d, 0.0000468985d },
            { 474000.0d, 0.0000466046d },
            { 476000.0d, 0.0000463079d },
            { 478000.0d, 0.0000460083d },
            { 480000.0d, 0.0000457061d },
            { 482000.0d, 0.0000454012d },
            { 484000.0d, 0.0000450936d },
            { 486000.0d, 0.0000447834d },
            { 488000.0d, 0.0000444707d },
            { 490000.0d, 0.0000441554d },
            { 492000.0d, 0.0000438377d },
            { 494000.0d, 0.0000435176d },
            { 496000.0d, 0.0000431952d },
            { 498000.0d, 0.0000428704d },
            { 500000.0d, 0.0000425434d },
            { 502000.0d, 0.0000422142d },
            { 504000.0d, 0.0000418828d },
            { 506000.0d, 0.0000415493d },
            { 508000.0d, 0.0000412137d },
            { 510000.0d, 0.0000408761d },
            { 512000.0d, 0.0000405366d },
            { 514000.0d, 0.0000401951d },
            { 516000.0d, 0.0000398518d },
            { 518000.0d, 0.0000395066d },
            { 520000.0d, 0.0000391597d },
            { 522000.0d, 0.0000388111d },
            { 524000.0d, 0.0000384608d },
            { 526000.0d, 0.0000381089d },
            { 528000.0d, 0.0000377555d },
            { 530000.0d, 0.0000374005d },
            { 532000.0d, 0.0000370441d },
            { 534000.0d, 0.0000366863d },
            { 536000.0d, 0.0000363271d },
            { 538000.0d, 0.0000359666d },
            { 540000.0d, 0.0000356049d },
            { 542000.0d, 0.000035242d },
            { 544000.0d, 0.000034878d },
            { 546000.0d, 0.0000345128d },
            { 548000.0d, 0.0000341467d },
            { 550000.0d, 0.0000337795d },
            { 552000.0d, 0.0000334114d },
            { 554000.0d, 0.0000330425d },
            { 556000.0d, 0.0000326727d },
            { 558000.0d, 0.0000323022d },
            { 560000.0d, 0.000031931d },
            { 562000.0d, 0.0000315591d },
            { 564000.0d, 0.0000311866d },
            { 566000.0d, 0.0000308135d },
            { 568000.0d, 0.00003044d },
            { 570000.0d, 0.000030066d },
            { 572000.0d, 0.0000296917d },
            { 574000.0d, 0.000029317d },
            { 576000.0d, 0.0000289421d },
            { 578000.0d, 0.000028567d },
            { 580000.0d, 0.0000281917d },
            { 582000.0d, 0.0000278163d },
            { 584000.0d, 0.0000274409d },
            { 586000.0d, 0.0000270654d },
            { 588000.0d, 0.0000266901d },
            { 590000.0d, 0.0000263149d },
            { 592000.0d, 0.0000259399d },
            { 594000.0d, 0.0000255651d },
            { 596000.0d, 0.0000251906d },
            { 598000.0d, 0.0000248165d },
            { 600000.0d, 0.0000244429d },
            { 602000.0d, 0.0000240697d },
            { 604000.0d, 0.000023697d },
            { 606000.0d, 0.0000233249d },
            { 608000.0d, 0.0000229535d },
            { 610000.0d, 0.0000225828d },
            { 612000.0d, 0.0000222129d },
            { 614000.0d, 0.0000218438d },
            { 616000.0d, 0.0000214756d },
            { 618000.0d, 0.0000211084d },
            { 620000.0d, 0.0000207422d },
            { 622000.0d, 0.000020377d },
            { 624000.0d, 0.000020013d },
            { 626000.0d, 0.0000196502d },
            { 628000.0d, 0.0000192887d },
            { 630000.0d, 0.0000189284d },
            { 632000.0d, 0.0000185696d },
            { 634000.0d, 0.0000182121d },
            { 636000.0d, 0.0000178562d },
            { 638000.0d, 0.0000175019d },
            { 640000.0d, 0.0000171491d },
            { 642000.0d, 0.0000167981d },
            { 644000.0d, 0.0000164488d },
            { 646000.0d, 0.0000161013d },
            { 648000.0d, 0.0000157557d },
            { 650000.0d, 0.0000154121d },
            { 652000.0d, 0.0000150704d },
            { 654000.0d, 0.0000147308d },
            { 656000.0d, 0.0000143933d },
            { 658000.0d, 0.0000140581d },
            { 660000.0d, 0.000013725d },
            { 662000.0d, 0.0000133943d },
            { 664000.0d, 0.000013066d },
            { 666000.0d, 0.0000127401d },
            { 668000.0d, 0.0000124168d },
            { 670000.0d, 0.000012096d },
            { 672000.0d, 0.0000117779d },
            { 674000.0d, 0.0000114624d },
            { 676000.0d, 0.0000111498d },
            { 678000.0d, 0.0000108399d },
            { 680000.0d, 0.000010533d },
            { 682000.0d, 0.0000102291d },
            { 684000.0d, 0.00000992813d },
            { 686000.0d, 0.00000963031d },
            { 688000.0d, 0.00000933565d },
            { 690000.0d, 0.00000904422d },
            { 692000.0d, 0.0000087561d },
            { 694000.0d, 0.00000847133d },
            { 696000.0d, 0.00000819d },
            { 698000.0d, 0.00000791217d },
            { 700000.0d, 0.00000763791d },
            { 702000.0d, 0.00000736728d },
            { 704000.0d, 0.00000710035d },
            { 706000.0d, 0.00000683719d },
            { 708000.0d, 0.00000657786d },
            { 710000.0d, 0.00000632244d },
            { 712000.0d, 0.00000607099d },
            { 714000.0d, 0.00000582359d },
            { 716000.0d, 0.00000558029d },
            { 718000.0d, 0.00000534117d },
            { 720000.0d, 0.0000051063d },
            { 722000.0d, 0.00000487574d },
            { 724000.0d, 0.00000464957d },
            { 726000.0d, 0.00000442785d },
            { 728000.0d, 0.00000421066d },
            { 730000.0d, 0.00000399806d },
            { 732000.0d, 0.00000379012d },
            { 734000.0d, 0.00000358692d },
            { 736000.0d, 0.00000338852d },
            { 738000.0d, 0.00000319499d },
            { 740000.0d, 0.0000030064d },
            { 742000.0d, 0.00000282283d },
            { 744000.0d, 0.00000264434d },
            { 746000.0d, 0.00000247101d },
            { 748000.0d, 0.0000023029d },
            { 750000.0d, 0.00000214009d },
            { 752000.0d, 0.00000198265d },
            { 754000.0d, 0.00000183065d },
            { 756000.0d, 0.00000168415d },
            { 758000.0d, 0.00000154324d },
            { 760000.0d, 0.00000140799d },
            { 762000.0d, 0.00000127846d },
            { 764000.0d, 0.00000115472d },
            { 766000.0d, 0.00000103686d },
            { 768000.0d, 0.000000924935d },
            { 770000.0d, 0.000000819025d },
            { 772000.0d, 0.0000007192d },
            { 774000.0d, 0.000000625532d },
            { 776000.0d, 0.000000538094d },
            { 778000.0d, 0.000000456958d },
            { 780000.0d, 0.000000382196d },
            { 782000.0d, 0.00000031388d },
            { 784000.0d, 0.000000252082d },
            { 786000.0d, 0.000000196874d },
            { 788000.0d, 0.000000148329d },
            { 790000.0d, 0.000000106516d },
            { 792000.0d, 0.0000000715071d },
            { 794000.0d, 0.0000000433725d },
            { 796000.0d, 0.0000000221809d },
            { 798000.0d, 0.00000000799891d },
            { 800000.0d, 0.000000000888452d },
            { 801000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    