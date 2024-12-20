using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium146";
        public override double halfLife { get; } = 174509800.63949d;
        public override double atomicWeight { get; } = 145.9147d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.657d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium146()), new(0.0022d, new GammaParticle(146200.0, 0.00848)), new(0.647d, new GammaParticle(453830.0, 0.00273)), new(0.006d, new GammaParticle(589700.0, 0.0021)), new(0.22899999999999998d, new GammaParticle(735900.0, 0.00168)), new(0.0794164253736d, new GammaParticle(5870.0, 0.21122)), new(0.14388569082851302d, new GammaParticle(36848.0, 0.03365)), new(0.26203913827811515d, new GammaParticle(37362.0, 0.03318)), new(0.08047451663752725d, new GammaParticle(42380.0, 0.02926)), new(0.10115646741337175d, new GammaParticle(42810.0, 0.02896)), new(0.0206819507758445d, new GammaParticle(43335.0, 0.02861)) } },
            { 0.34299999999999997d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium146()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.022400000000000003d, new GammaParticle(633250.0, 0.00196)), new(0.341d, new GammaParticle(747240.0, 0.00166)), new(0.00023256624508d, new GammaParticle(6354.0, 0.19513)), new(0.00038057406383379763d, new GammaParticle(39522.0, 0.03137)), new(0.0006888218349932988d, new GammaParticle(40117.0, 0.03091)), new(0.00021532430935842888d, new GammaParticle(45523.0, 0.02724)), new(0.0002708779811729035d, new GammaParticle(45998.0, 0.02695)), new(5.555367181447465e-05d, new GammaParticle(46575.0, 0.02662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00121689d },
            { 500.0d, 0.00117743d },
            { 1000.0d, 0.00115412d },
            { 1500.0d, 0.00114697d },
            { 2000.0d, 0.00114363d },
            { 2500.0d, 0.00114154d },
            { 3000.0d, 0.00113992d },
            { 3500.0d, 0.00113849d },
            { 4000.0d, 0.00113713d },
            { 4500.0d, 0.00113579d },
            { 5000.0d, 0.00113445d },
            { 5500.0d, 0.00113309d },
            { 6000.0d, 0.00113173d },
            { 6500.0d, 0.00113035d },
            { 7000.0d, 0.00112895d },
            { 7500.0d, 0.00112754d },
            { 8000.0d, 0.00112612d },
            { 8500.0d, 0.00112469d },
            { 9000.0d, 0.00112325d },
            { 9500.0d, 0.0011218d },
            { 10000.0d, 0.00112035d },
            { 11000.0d, 0.00111741d },
            { 12000.0d, 0.00111446d },
            { 13000.0d, 0.00111149d },
            { 14000.0d, 0.00110849d },
            { 15000.0d, 0.00110549d },
            { 16000.0d, 0.00110247d },
            { 17000.0d, 0.00109944d },
            { 18000.0d, 0.0010964d },
            { 19000.0d, 0.00109335d },
            { 20000.0d, 0.00109029d },
            { 21000.0d, 0.00108722d },
            { 22000.0d, 0.00108414d },
            { 23000.0d, 0.00108106d },
            { 24000.0d, 0.00107796d },
            { 25000.0d, 0.00107487d },
            { 26000.0d, 0.00107176d },
            { 27000.0d, 0.00106865d },
            { 28000.0d, 0.00106554d },
            { 29000.0d, 0.00106242d },
            { 30000.0d, 0.0010593d },
            { 31000.0d, 0.00105618d },
            { 32000.0d, 0.00105305d },
            { 33000.0d, 0.00104992d },
            { 34000.0d, 0.00104678d },
            { 35000.0d, 0.00104365d },
            { 36000.0d, 0.00104051d },
            { 37000.0d, 0.00103737d },
            { 38000.0d, 0.00103424d },
            { 39000.0d, 0.0010311d },
            { 40000.0d, 0.00102796d },
            { 41000.0d, 0.00102482d },
            { 42000.0d, 0.00102168d },
            { 43000.0d, 0.00101854d },
            { 44000.0d, 0.00101541d },
            { 45000.0d, 0.00101227d },
            { 46000.0d, 0.00100914d },
            { 47000.0d, 0.00100601d },
            { 48000.0d, 0.00100288d },
            { 49000.0d, 0.000999758d },
            { 50000.0d, 0.000996636d },
            { 51000.0d, 0.000993517d },
            { 52000.0d, 0.000990402d },
            { 53000.0d, 0.000987291d },
            { 54000.0d, 0.000984183d },
            { 55000.0d, 0.00098108d },
            { 56000.0d, 0.000977983d },
            { 57000.0d, 0.000974891d },
            { 58000.0d, 0.000971803d },
            { 59000.0d, 0.000968721d },
            { 60000.0d, 0.000965645d },
            { 61000.0d, 0.000962576d },
            { 62000.0d, 0.000959512d },
            { 63000.0d, 0.000956455d },
            { 64000.0d, 0.000953406d },
            { 65000.0d, 0.000950363d },
            { 66000.0d, 0.000947328d },
            { 67000.0d, 0.000944301d },
            { 68000.0d, 0.000941281d },
            { 69000.0d, 0.00093827d },
            { 70000.0d, 0.000935268d },
            { 71000.0d, 0.000932274d },
            { 72000.0d, 0.00092929d },
            { 73000.0d, 0.000926315d },
            { 74000.0d, 0.00092335d },
            { 75000.0d, 0.000920395d },
            { 76000.0d, 0.000917451d },
            { 77000.0d, 0.000914516d },
            { 78000.0d, 0.000911592d },
            { 79000.0d, 0.000908679d },
            { 80000.0d, 0.000905778d },
            { 81000.0d, 0.000902888d },
            { 82000.0d, 0.000900011d },
            { 83000.0d, 0.000897146d },
            { 84000.0d, 0.000894292d },
            { 85000.0d, 0.000891451d },
            { 86000.0d, 0.000888624d },
            { 87000.0d, 0.000885811d },
            { 88000.0d, 0.00088301d },
            { 89000.0d, 0.000880224d },
            { 90000.0d, 0.000877452d },
            { 91000.0d, 0.000874694d },
            { 92000.0d, 0.000871951d },
            { 93000.0d, 0.000869223d },
            { 94000.0d, 0.000866511d },
            { 95000.0d, 0.000863814d },
            { 96000.0d, 0.000861133d },
            { 97000.0d, 0.000858469d },
            { 98000.0d, 0.000855821d },
            { 99000.0d, 0.00085319d },
            { 100000.0d, 0.000850576d },
            { 102000.0d, 0.000845402d },
            { 104000.0d, 0.000840298d },
            { 106000.0d, 0.000835272d },
            { 108000.0d, 0.000830321d },
            { 110000.0d, 0.000825451d },
            { 112000.0d, 0.000820662d },
            { 114000.0d, 0.00081596d },
            { 116000.0d, 0.000811344d },
            { 118000.0d, 0.00080682d },
            { 120000.0d, 0.000802387d },
            { 122000.0d, 0.00079805d },
            { 124000.0d, 0.000793811d },
            { 126000.0d, 0.000789674d },
            { 128000.0d, 0.000785639d },
            { 130000.0d, 0.000781711d },
            { 132000.0d, 0.000777891d },
            { 134000.0d, 0.000774184d },
            { 136000.0d, 0.000770591d },
            { 138000.0d, 0.000767115d },
            { 140000.0d, 0.000763758d },
            { 142000.0d, 0.000760526d },
            { 144000.0d, 0.000757419d },
            { 146000.0d, 0.000754441d },
            { 148000.0d, 0.000751594d },
            { 150000.0d, 0.000748881d },
            { 152000.0d, 0.000746306d },
            { 154000.0d, 0.000743871d },
            { 156000.0d, 0.000741579d },
            { 158000.0d, 0.000739433d },
            { 160000.0d, 0.000737437d },
            { 162000.0d, 0.000735586d },
            { 164000.0d, 0.00073376d },
            { 166000.0d, 0.000731907d },
            { 168000.0d, 0.000730029d },
            { 170000.0d, 0.000728124d },
            { 172000.0d, 0.000726194d },
            { 174000.0d, 0.000724239d },
            { 176000.0d, 0.000722258d },
            { 178000.0d, 0.000720252d },
            { 180000.0d, 0.000718222d },
            { 182000.0d, 0.000716166d },
            { 184000.0d, 0.000714087d },
            { 186000.0d, 0.000711983d },
            { 188000.0d, 0.000709856d },
            { 190000.0d, 0.000707704d },
            { 192000.0d, 0.000705529d },
            { 194000.0d, 0.000703331d },
            { 196000.0d, 0.00070111d },
            { 198000.0d, 0.000698866d },
            { 200000.0d, 0.000696599d },
            { 202000.0d, 0.00069431d },
            { 204000.0d, 0.000691998d },
            { 206000.0d, 0.000689665d },
            { 208000.0d, 0.00068731d },
            { 210000.0d, 0.000684933d },
            { 212000.0d, 0.000682535d },
            { 214000.0d, 0.000680116d },
            { 216000.0d, 0.000677676d },
            { 218000.0d, 0.000675216d },
            { 220000.0d, 0.000672735d },
            { 222000.0d, 0.000670234d },
            { 224000.0d, 0.000667714d },
            { 226000.0d, 0.000665174d },
            { 228000.0d, 0.000662614d },
            { 230000.0d, 0.000660035d },
            { 232000.0d, 0.000657437d },
            { 234000.0d, 0.000654821d },
            { 236000.0d, 0.000652186d },
            { 238000.0d, 0.000649533d },
            { 240000.0d, 0.000646862d },
            { 242000.0d, 0.000644173d },
            { 244000.0d, 0.000641467d },
            { 246000.0d, 0.000638744d },
            { 248000.0d, 0.000636004d },
            { 250000.0d, 0.000633247d },
            { 252000.0d, 0.000630473d },
            { 254000.0d, 0.000627683d },
            { 256000.0d, 0.000624878d },
            { 258000.0d, 0.000622056d },
            { 260000.0d, 0.00061922d },
            { 262000.0d, 0.000616367d },
            { 264000.0d, 0.0006135d },
            { 266000.0d, 0.000610618d },
            { 268000.0d, 0.000607722d },
            { 270000.0d, 0.000604812d },
            { 272000.0d, 0.000601887d },
            { 274000.0d, 0.000598949d },
            { 276000.0d, 0.000595997d },
            { 278000.0d, 0.000593032d },
            { 280000.0d, 0.000590054d },
            { 282000.0d, 0.000587063d },
            { 284000.0d, 0.00058406d },
            { 286000.0d, 0.000581045d },
            { 288000.0d, 0.000578017d },
            { 290000.0d, 0.000574978d },
            { 292000.0d, 0.000571928d },
            { 294000.0d, 0.000568866d },
            { 296000.0d, 0.000565793d },
            { 298000.0d, 0.000562709d },
            { 300000.0d, 0.000559615d },
            { 302000.0d, 0.000556511d },
            { 304000.0d, 0.000553397d },
            { 306000.0d, 0.000550273d },
            { 308000.0d, 0.00054714d },
            { 310000.0d, 0.000543997d },
            { 312000.0d, 0.000540845d },
            { 314000.0d, 0.000537685d },
            { 316000.0d, 0.000534516d },
            { 318000.0d, 0.000531339d },
            { 320000.0d, 0.000528154d },
            { 322000.0d, 0.000524961d },
            { 324000.0d, 0.000521761d },
            { 326000.0d, 0.000518554d },
            { 328000.0d, 0.000515339d },
            { 330000.0d, 0.000512118d },
            { 332000.0d, 0.00050889d },
            { 334000.0d, 0.000505657d },
            { 336000.0d, 0.000502417d },
            { 338000.0d, 0.000499171d },
            { 340000.0d, 0.00049592d },
            { 342000.0d, 0.000492663d },
            { 344000.0d, 0.000489402d },
            { 346000.0d, 0.000486136d },
            { 348000.0d, 0.000482865d },
            { 350000.0d, 0.00047959d },
            { 352000.0d, 0.000476311d },
            { 354000.0d, 0.000473028d },
            { 356000.0d, 0.000469742d },
            { 358000.0d, 0.000466452d },
            { 360000.0d, 0.000463159d },
            { 362000.0d, 0.000459864d },
            { 364000.0d, 0.000456565d },
            { 366000.0d, 0.000453265d },
            { 368000.0d, 0.000449962d },
            { 370000.0d, 0.000446657d },
            { 372000.0d, 0.000443351d },
            { 374000.0d, 0.000440043d },
            { 376000.0d, 0.000436735d },
            { 378000.0d, 0.000433425d },
            { 380000.0d, 0.000430114d },
            { 382000.0d, 0.000426803d },
            { 384000.0d, 0.000423492d },
            { 386000.0d, 0.000420181d },
            { 388000.0d, 0.00041687d },
            { 390000.0d, 0.000413559d },
            { 392000.0d, 0.000410249d },
            { 394000.0d, 0.00040694d },
            { 396000.0d, 0.000403632d },
            { 398000.0d, 0.000400326d },
            { 400000.0d, 0.000397021d },
            { 402000.0d, 0.000393718d },
            { 404000.0d, 0.000390417d },
            { 406000.0d, 0.000387118d },
            { 408000.0d, 0.000383822d },
            { 410000.0d, 0.000380528d },
            { 412000.0d, 0.000377237d },
            { 414000.0d, 0.00037395d },
            { 416000.0d, 0.000370666d },
            { 418000.0d, 0.000367385d },
            { 420000.0d, 0.000364108d },
            { 422000.0d, 0.000360836d },
            { 424000.0d, 0.000357567d },
            { 426000.0d, 0.000354303d },
            { 428000.0d, 0.000351044d },
            { 430000.0d, 0.000347789d },
            { 432000.0d, 0.00034454d },
            { 434000.0d, 0.000341296d },
            { 436000.0d, 0.000338057d },
            { 438000.0d, 0.000334825d },
            { 440000.0d, 0.000331598d },
            { 442000.0d, 0.000328377d },
            { 444000.0d, 0.000325162d },
            { 446000.0d, 0.000321955d },
            { 448000.0d, 0.000318753d },
            { 450000.0d, 0.000315559d },
            { 452000.0d, 0.000312372d },
            { 454000.0d, 0.000309193d },
            { 456000.0d, 0.000306021d },
            { 458000.0d, 0.000302856d },
            { 460000.0d, 0.0002997d },
            { 462000.0d, 0.000296552d },
            { 464000.0d, 0.000293412d },
            { 466000.0d, 0.000290281d },
            { 468000.0d, 0.000287158d },
            { 470000.0d, 0.000284045d },
            { 472000.0d, 0.00028094d },
            { 474000.0d, 0.000277845d },
            { 476000.0d, 0.000274759d },
            { 478000.0d, 0.000271683d },
            { 480000.0d, 0.000268617d },
            { 482000.0d, 0.000265561d },
            { 484000.0d, 0.000262515d },
            { 486000.0d, 0.00025948d },
            { 488000.0d, 0.000256455d },
            { 490000.0d, 0.000253441d },
            { 492000.0d, 0.000250439d },
            { 494000.0d, 0.000247447d },
            { 496000.0d, 0.000244466d },
            { 498000.0d, 0.000241497d },
            { 500000.0d, 0.00023854d },
            { 502000.0d, 0.000235595d },
            { 504000.0d, 0.000232661d },
            { 506000.0d, 0.00022974d },
            { 508000.0d, 0.000226831d },
            { 510000.0d, 0.000223935d },
            { 512000.0d, 0.000221052d },
            { 514000.0d, 0.000218181d },
            { 516000.0d, 0.000215324d },
            { 518000.0d, 0.000212479d },
            { 520000.0d, 0.000209648d },
            { 522000.0d, 0.000206831d },
            { 524000.0d, 0.000204027d },
            { 526000.0d, 0.000201237d },
            { 528000.0d, 0.000198461d },
            { 530000.0d, 0.0001957d },
            { 532000.0d, 0.000192952d },
            { 534000.0d, 0.000190219d },
            { 536000.0d, 0.000187501d },
            { 538000.0d, 0.000184798d },
            { 540000.0d, 0.000182109d },
            { 542000.0d, 0.000179436d },
            { 544000.0d, 0.000176778d },
            { 546000.0d, 0.000174135d },
            { 548000.0d, 0.000171507d },
            { 550000.0d, 0.000168896d },
            { 552000.0d, 0.0001663d },
            { 554000.0d, 0.00016372d },
            { 556000.0d, 0.000161157d },
            { 558000.0d, 0.000158609d },
            { 560000.0d, 0.000156078d },
            { 562000.0d, 0.000153563d },
            { 564000.0d, 0.000151066d },
            { 566000.0d, 0.000148584d },
            { 568000.0d, 0.00014612d },
            { 570000.0d, 0.000143673d },
            { 572000.0d, 0.000141243d },
            { 574000.0d, 0.00013883d },
            { 576000.0d, 0.000136435d },
            { 578000.0d, 0.000134057d },
            { 580000.0d, 0.000131698d },
            { 582000.0d, 0.000129355d },
            { 584000.0d, 0.000127031d },
            { 586000.0d, 0.000124725d },
            { 588000.0d, 0.000122437d },
            { 590000.0d, 0.000120167d },
            { 592000.0d, 0.000117916d },
            { 594000.0d, 0.000115683d },
            { 596000.0d, 0.000113469d },
            { 598000.0d, 0.000111274d },
            { 600000.0d, 0.000109097d },
            { 602000.0d, 0.00010694d },
            { 604000.0d, 0.000104801d },
            { 606000.0d, 0.000102682d },
            { 608000.0d, 0.000100582d },
            { 610000.0d, 0.0000985014d },
            { 612000.0d, 0.0000964404d },
            { 614000.0d, 0.0000943989d },
            { 616000.0d, 0.0000923772d },
            { 618000.0d, 0.0000903753d },
            { 620000.0d, 0.0000883933d },
            { 622000.0d, 0.0000864314d },
            { 624000.0d, 0.0000844895d },
            { 626000.0d, 0.0000825678d },
            { 628000.0d, 0.0000806664d },
            { 630000.0d, 0.0000787854d },
            { 632000.0d, 0.0000769249d },
            { 634000.0d, 0.0000750849d },
            { 636000.0d, 0.0000732656d },
            { 638000.0d, 0.000071467d },
            { 640000.0d, 0.0000696892d },
            { 642000.0d, 0.0000679324d },
            { 644000.0d, 0.0000661965d },
            { 646000.0d, 0.0000644817d },
            { 648000.0d, 0.0000627881d },
            { 650000.0d, 0.0000611156d },
            { 652000.0d, 0.0000594645d },
            { 654000.0d, 0.0000578348d },
            { 656000.0d, 0.0000562265d },
            { 658000.0d, 0.0000546398d },
            { 660000.0d, 0.0000530746d },
            { 662000.0d, 0.0000515312d },
            { 664000.0d, 0.0000500094d },
            { 666000.0d, 0.0000485095d },
            { 668000.0d, 0.0000470315d },
            { 670000.0d, 0.0000455754d },
            { 672000.0d, 0.0000441413d },
            { 674000.0d, 0.0000427292d },
            { 676000.0d, 0.0000413393d },
            { 678000.0d, 0.0000399716d },
            { 680000.0d, 0.0000386261d },
            { 682000.0d, 0.000037303d },
            { 684000.0d, 0.0000360022d },
            { 686000.0d, 0.0000347238d },
            { 688000.0d, 0.0000334679d },
            { 690000.0d, 0.0000322345d },
            { 692000.0d, 0.0000310237d },
            { 694000.0d, 0.0000298355d },
            { 696000.0d, 0.00002867d },
            { 698000.0d, 0.0000275272d },
            { 700000.0d, 0.0000264071d },
            { 702000.0d, 0.0000253099d },
            { 704000.0d, 0.0000242355d },
            { 706000.0d, 0.0000231841d },
            { 708000.0d, 0.0000221555d },
            { 710000.0d, 0.0000211499d },
            { 712000.0d, 0.0000201674d },
            { 714000.0d, 0.0000192079d },
            { 716000.0d, 0.0000182715d },
            { 718000.0d, 0.0000173582d },
            { 720000.0d, 0.000016468d },
            { 722000.0d, 0.000015601d },
            { 724000.0d, 0.0000147573d },
            { 726000.0d, 0.0000139368d },
            { 728000.0d, 0.0000131396d },
            { 730000.0d, 0.0000123657d },
            { 732000.0d, 0.0000116151d },
            { 734000.0d, 0.0000108878d },
            { 736000.0d, 0.0000101839d },
            { 738000.0d, 0.00000950348d },
            { 740000.0d, 0.00000884642d },
            { 742000.0d, 0.00000821281d },
            { 744000.0d, 0.00000760265d },
            { 746000.0d, 0.00000701596d },
            { 748000.0d, 0.00000645276d },
            { 750000.0d, 0.00000591307d },
            { 752000.0d, 0.0000053969d },
            { 754000.0d, 0.00000490426d },
            { 756000.0d, 0.00000443516d },
            { 758000.0d, 0.00000398961d },
            { 760000.0d, 0.00000356762d },
            { 762000.0d, 0.0000031692d },
            { 764000.0d, 0.00000279436d },
            { 766000.0d, 0.0000024431d },
            { 768000.0d, 0.00000211543d },
            { 770000.0d, 0.00000181134d },
            { 772000.0d, 0.00000153084d },
            { 774000.0d, 0.00000127394d },
            { 776000.0d, 0.00000104063d },
            { 778000.0d, 0.000000830911d },
            { 780000.0d, 0.000000644779d },
            { 782000.0d, 0.000000482231d },
            { 784000.0d, 0.000000343264d },
            { 786000.0d, 0.00000022787d },
            { 788000.0d, 0.000000136043d },
            { 790000.0d, 0.0000000677761d },
            { 792000.0d, 0.0000000230591d },
            { 794000.0d, 0.00000000188206d },
            { 794800.0d, 0d },

        }; 
    }
}
    