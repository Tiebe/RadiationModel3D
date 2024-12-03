using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium90m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium90m";
        public override double halfLife { get; } = 11484.0d;
        public override double atomicWeight { get; } = 89.90787d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9999819999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium90()), new(0.97d, new GammaParticle(202530.0, 0.00612)), new(0.905d, new GammaParticle(479510.0, 0.00259)), new(0.0032d, new GammaParticle(681800.0, 0.00182)), new(0.003442157308458d, new GammaParticle(2027.0, 0.61166)), new(0.02024856148490041d, new GammaParticle(14883.0, 0.08331)), new(0.03882753880134306d, new GammaParticle(14958.0, 0.08289)), new(0.009749113913670058d, new GammaParticle(16803.0, 0.07379)), new(0.011094491633756524d, new GammaParticle(16880.0, 0.07345)), new(0.0013453777200864681d, new GammaParticle(17011.0, 0.07288)) } },
            { 1.8e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium90()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.8e-05d, new GammaParticle(2318968.0, 0.00053)), new(2.7365747760000003e-10d, new GammaParticle(2161.0, 0.57374)), new(1.5522238085042538e-09d, new GammaParticle(15691.0, 0.07902)), new(2.9707632698646005e-09d, new GammaParticle(15775.0, 0.0786)), new(7.569885878107734e-10d, new GammaParticle(17736.0, 0.06991)), new(8.675089216311462e-10d, new GammaParticle(17824.0, 0.06956)), new(1.105203338203729e-10d, new GammaParticle(17968.0, 0.069)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000000428977d },
            { 2000.0d, 0.0000000432507d },
            { 4000.0d, 0.0000000434257d },
            { 6000.0d, 0.0000000434225d },
            { 8000.0d, 0.0000000433906d },
            { 10000.0d, 0.0000000433469d },
            { 12000.0d, 0.0000000432963d },
            { 14000.0d, 0.0000000432416d },
            { 16000.0d, 0.0000000431849d },
            { 18000.0d, 0.0000000431277d },
            { 20000.0d, 0.0000000430709d },
            { 22000.0d, 0.0000000430153d },
            { 24000.0d, 0.0000000429613d },
            { 26000.0d, 0.0000000429091d },
            { 28000.0d, 0.0000000428589d },
            { 30000.0d, 0.0000000428106d },
            { 32000.0d, 0.0000000427643d },
            { 34000.0d, 0.0000000427199d },
            { 36000.0d, 0.0000000426772d },
            { 38000.0d, 0.0000000426362d },
            { 40000.0d, 0.0000000425968d },
            { 42000.0d, 0.0000000425588d },
            { 44000.0d, 0.0000000425221d },
            { 46000.0d, 0.0000000424866d },
            { 48000.0d, 0.0000000424522d },
            { 50000.0d, 0.0000000424187d },
            { 52000.0d, 0.0000000423861d },
            { 54000.0d, 0.0000000423543d },
            { 56000.0d, 0.0000000423232d },
            { 58000.0d, 0.0000000422926d },
            { 60000.0d, 0.0000000422626d },
            { 62000.0d, 0.000000042233d },
            { 64000.0d, 0.0000000422037d },
            { 66000.0d, 0.0000000421748d },
            { 68000.0d, 0.0000000421461d },
            { 70000.0d, 0.0000000421177d },
            { 72000.0d, 0.0000000420893d },
            { 74000.0d, 0.0000000420611d },
            { 76000.0d, 0.0000000420329d },
            { 78000.0d, 0.0000000420047d },
            { 80000.0d, 0.0000000419765d },
            { 82000.0d, 0.0000000419482d },
            { 84000.0d, 0.0000000419198d },
            { 86000.0d, 0.0000000418913d },
            { 88000.0d, 0.0000000418626d },
            { 90000.0d, 0.0000000418337d },
            { 92000.0d, 0.0000000418047d },
            { 94000.0d, 0.0000000417754d },
            { 96000.0d, 0.0000000417458d },
            { 98000.0d, 0.000000041716d },
            { 100000.0d, 0.0000000416859d },
            { 102000.0d, 0.0000000416554d },
            { 104000.0d, 0.0000000416247d },
            { 106000.0d, 0.0000000415935d },
            { 108000.0d, 0.0000000415621d },
            { 110000.0d, 0.0000000415302d },
            { 112000.0d, 0.0000000414979d },
            { 114000.0d, 0.0000000414653d },
            { 116000.0d, 0.0000000414322d },
            { 118000.0d, 0.0000000413987d },
            { 120000.0d, 0.0000000413648d },
            { 122000.0d, 0.0000000413304d },
            { 124000.0d, 0.0000000412955d },
            { 126000.0d, 0.0000000412601d },
            { 128000.0d, 0.0000000412243d },
            { 130000.0d, 0.000000041188d },
            { 132000.0d, 0.0000000411511d },
            { 134000.0d, 0.0000000411137d },
            { 136000.0d, 0.0000000410758d },
            { 138000.0d, 0.0000000410374d },
            { 140000.0d, 0.0000000409984d },
            { 142000.0d, 0.0000000409588d },
            { 144000.0d, 0.0000000409187d },
            { 146000.0d, 0.000000040878d },
            { 148000.0d, 0.0000000408367d },
            { 150000.0d, 0.0000000407948d },
            { 152000.0d, 0.0000000407523d },
            { 154000.0d, 0.0000000407091d },
            { 156000.0d, 0.0000000406653d },
            { 158000.0d, 0.0000000406209d },
            { 160000.0d, 0.0000000405758d },
            { 162000.0d, 0.0000000405301d },
            { 164000.0d, 0.0000000404837d },
            { 166000.0d, 0.0000000404366d },
            { 168000.0d, 0.0000000403888d },
            { 170000.0d, 0.0000000403403d },
            { 172000.0d, 0.0000000402911d },
            { 174000.0d, 0.0000000402411d },
            { 176000.0d, 0.0000000401904d },
            { 178000.0d, 0.000000040139d },
            { 180000.0d, 0.0000000400868d },
            { 182000.0d, 0.0000000400338d },
            { 184000.0d, 0.00000003998d },
            { 186000.0d, 0.0000000399255d },
            { 188000.0d, 0.0000000398701d },
            { 190000.0d, 0.0000000398139d },
            { 192000.0d, 0.0000000397568d },
            { 194000.0d, 0.0000000396989d },
            { 196000.0d, 0.0000000396402d },
            { 198000.0d, 0.0000000395805d },
            { 200000.0d, 0.00000003952d },
            { 202000.0d, 0.0000000394586d },
            { 204000.0d, 0.0000000393962d },
            { 206000.0d, 0.0000000393329d },
            { 208000.0d, 0.0000000392687d },
            { 210000.0d, 0.0000000392036d },
            { 212000.0d, 0.0000000391374d },
            { 214000.0d, 0.0000000390703d },
            { 216000.0d, 0.0000000390022d },
            { 218000.0d, 0.000000038933d },
            { 220000.0d, 0.0000000388629d },
            { 222000.0d, 0.0000000387916d },
            { 224000.0d, 0.0000000387194d },
            { 226000.0d, 0.000000038646d },
            { 228000.0d, 0.0000000385716d },
            { 230000.0d, 0.0000000384961d },
            { 232000.0d, 0.0000000384194d },
            { 234000.0d, 0.0000000383417d },
            { 236000.0d, 0.0000000382627d },
            { 238000.0d, 0.0000000381827d },
            { 240000.0d, 0.0000000381014d },
            { 242000.0d, 0.000000038019d },
            { 244000.0d, 0.0000000379353d },
            { 246000.0d, 0.0000000378504d },
            { 248000.0d, 0.0000000377643d },
            { 250000.0d, 0.0000000376769d },
            { 252000.0d, 0.0000000375883d },
            { 254000.0d, 0.0000000374983d },
            { 256000.0d, 0.0000000374071d },
            { 258000.0d, 0.0000000373146d },
            { 260000.0d, 0.0000000372207d },
            { 262000.0d, 0.0000000371255d },
            { 264000.0d, 0.0000000370289d },
            { 266000.0d, 0.0000000369309d },
            { 268000.0d, 0.0000000368315d },
            { 270000.0d, 0.0000000367308d },
            { 272000.0d, 0.0000000366286d },
            { 274000.0d, 0.0000000365249d },
            { 276000.0d, 0.0000000364198d },
            { 278000.0d, 0.0000000363133d },
            { 280000.0d, 0.0000000362052d },
            { 282000.0d, 0.0000000360957d },
            { 284000.0d, 0.0000000359846d },
            { 286000.0d, 0.000000035872d },
            { 288000.0d, 0.0000000357579d },
            { 290000.0d, 0.0000000356422d },
            { 292000.0d, 0.0000000355249d },
            { 294000.0d, 0.000000035406d },
            { 296000.0d, 0.0000000352856d },
            { 298000.0d, 0.0000000351635d },
            { 300000.0d, 0.0000000350398d },
            { 302000.0d, 0.0000000349144d },
            { 304000.0d, 0.0000000347874d },
            { 306000.0d, 0.0000000346587d },
            { 308000.0d, 0.0000000345283d },
            { 310000.0d, 0.0000000343963d },
            { 312000.0d, 0.0000000342625d },
            { 314000.0d, 0.000000034127d },
            { 316000.0d, 0.0000000339898d },
            { 318000.0d, 0.0000000338508d },
            { 320000.0d, 0.0000000337101d },
            { 322000.0d, 0.0000000335676d },
            { 324000.0d, 0.0000000334233d },
            { 326000.0d, 0.0000000332772d },
            { 328000.0d, 0.0000000331294d },
            { 330000.0d, 0.0000000329797d },
            { 332000.0d, 0.0000000328282d },
            { 334000.0d, 0.0000000326749d },
            { 336000.0d, 0.0000000325197d },
            { 338000.0d, 0.0000000323627d },
            { 340000.0d, 0.0000000322038d },
            { 342000.0d, 0.0000000320431d },
            { 344000.0d, 0.0000000318805d },
            { 346000.0d, 0.000000031716d },
            { 348000.0d, 0.0000000315497d },
            { 350000.0d, 0.0000000313814d },
            { 352000.0d, 0.0000000312113d },
            { 354000.0d, 0.0000000310393d },
            { 356000.0d, 0.0000000308653d },
            { 358000.0d, 0.0000000306894d },
            { 360000.0d, 0.0000000305117d },
            { 362000.0d, 0.000000030332d },
            { 364000.0d, 0.0000000301504d },
            { 366000.0d, 0.0000000299669d },
            { 368000.0d, 0.0000000297814d },
            { 370000.0d, 0.000000029594d },
            { 372000.0d, 0.0000000294047d },
            { 374000.0d, 0.0000000292135d },
            { 376000.0d, 0.0000000290204d },
            { 378000.0d, 0.0000000288253d },
            { 380000.0d, 0.0000000286283d },
            { 382000.0d, 0.0000000284294d },
            { 384000.0d, 0.0000000282286d },
            { 386000.0d, 0.0000000280258d },
            { 388000.0d, 0.0000000278212d },
            { 390000.0d, 0.0000000276147d },
            { 392000.0d, 0.0000000274062d },
            { 394000.0d, 0.0000000271959d },
            { 396000.0d, 0.0000000269837d },
            { 398000.0d, 0.0000000267696d },
            { 400000.0d, 0.0000000265536d },
            { 402000.0d, 0.0000000263358d },
            { 404000.0d, 0.0000000261162d },
            { 406000.0d, 0.0000000258947d },
            { 408000.0d, 0.0000000256714d },
            { 410000.0d, 0.0000000254463d },
            { 412000.0d, 0.0000000252194d },
            { 414000.0d, 0.0000000249907d },
            { 416000.0d, 0.0000000247602d },
            { 418000.0d, 0.000000024528d },
            { 420000.0d, 0.0000000242941d },
            { 422000.0d, 0.0000000240584d },
            { 424000.0d, 0.0000000238211d },
            { 426000.0d, 0.0000000235821d },
            { 428000.0d, 0.0000000233414d },
            { 430000.0d, 0.0000000230991d },
            { 432000.0d, 0.0000000228552d },
            { 434000.0d, 0.0000000226097d },
            { 436000.0d, 0.0000000223626d },
            { 438000.0d, 0.000000022114d },
            { 440000.0d, 0.0000000218639d },
            { 442000.0d, 0.0000000216124d },
            { 444000.0d, 0.0000000213593d },
            { 446000.0d, 0.0000000211049d },
            { 448000.0d, 0.000000020849d },
            { 450000.0d, 0.0000000205918d },
            { 452000.0d, 0.0000000203333d },
            { 454000.0d, 0.0000000200735d },
            { 456000.0d, 0.0000000198124d },
            { 458000.0d, 0.0000000195502d },
            { 460000.0d, 0.0000000192867d },
            { 462000.0d, 0.0000000190221d },
            { 464000.0d, 0.0000000187564d },
            { 466000.0d, 0.0000000184897d },
            { 468000.0d, 0.0000000182219d },
            { 470000.0d, 0.0000000179532d },
            { 472000.0d, 0.0000000176836d },
            { 474000.0d, 0.0000000174131d },
            { 476000.0d, 0.0000000171417d },
            { 478000.0d, 0.0000000168696d },
            { 480000.0d, 0.0000000165967d },
            { 482000.0d, 0.0000000163232d },
            { 484000.0d, 0.0000000160491d },
            { 486000.0d, 0.0000000157744d },
            { 488000.0d, 0.0000000154992d },
            { 490000.0d, 0.0000000152236d },
            { 492000.0d, 0.0000000149475d },
            { 494000.0d, 0.0000000146712d },
            { 496000.0d, 0.0000000143945d },
            { 498000.0d, 0.0000000141177d },
            { 500000.0d, 0.0000000138407d },
            { 502000.0d, 0.0000000135637d },
            { 504000.0d, 0.0000000132867d },
            { 506000.0d, 0.0000000130097d },
            { 508000.0d, 0.0000000127329d },
            { 510000.0d, 0.0000000124563d },
            { 512000.0d, 0.00000001218d },
            { 514000.0d, 0.0000000119041d },
            { 516000.0d, 0.0000000116286d },
            { 518000.0d, 0.0000000113537d },
            { 520000.0d, 0.0000000110794d },
            { 522000.0d, 0.0000000108057d },
            { 524000.0d, 0.0000000105329d },
            { 526000.0d, 0.0000000102609d },
            { 528000.0d, 0.00000000998985d },
            { 530000.0d, 0.00000000971987d },
            { 532000.0d, 0.00000000945103d },
            { 534000.0d, 0.00000000918343d },
            { 536000.0d, 0.00000000891716d },
            { 538000.0d, 0.00000000865232d },
            { 540000.0d, 0.00000000838902d },
            { 542000.0d, 0.00000000812734d },
            { 544000.0d, 0.00000000786741d },
            { 546000.0d, 0.00000000760931d },
            { 548000.0d, 0.00000000735317d },
            { 550000.0d, 0.00000000709909d },
            { 552000.0d, 0.00000000684718d },
            { 554000.0d, 0.00000000659757d },
            { 556000.0d, 0.00000000635035d },
            { 558000.0d, 0.00000000610565d },
            { 560000.0d, 0.0000000058636d },
            { 562000.0d, 0.00000000562431d },
            { 564000.0d, 0.00000000538791d },
            { 566000.0d, 0.00000000515452d },
            { 568000.0d, 0.00000000492428d },
            { 570000.0d, 0.00000000469731d },
            { 572000.0d, 0.00000000447375d },
            { 574000.0d, 0.00000000425373d },
            { 576000.0d, 0.00000000403739d },
            { 578000.0d, 0.00000000382487d },
            { 580000.0d, 0.00000000361631d },
            { 582000.0d, 0.00000000341186d },
            { 584000.0d, 0.00000000321166d },
            { 586000.0d, 0.00000000301586d },
            { 588000.0d, 0.00000000282461d },
            { 590000.0d, 0.00000000263807d },
            { 592000.0d, 0.0000000024564d },
            { 594000.0d, 0.00000000227974d },
            { 596000.0d, 0.00000000210826d },
            { 598000.0d, 0.00000000194212d },
            { 600000.0d, 0.0000000017815d },
            { 602000.0d, 0.00000000162655d },
            { 604000.0d, 0.00000000147745d },
            { 606000.0d, 0.00000000133438d },
            { 608000.0d, 0.00000000119749d },
            { 610000.0d, 0.00000000106698d },
            { 612000.0d, 0.000000000943031d },
            { 614000.0d, 0.000000000825813d },
            { 616000.0d, 0.000000000715519d },
            { 618000.0d, 0.000000000612334d },
            { 620000.0d, 0.000000000516451d },
            { 622000.0d, 0.00000000042806d },
            { 624000.0d, 0.000000000347359d },
            { 626000.0d, 0.000000000274543d },
            { 628000.0d, 0.000000000209814d },
            { 630000.0d, 0.000000000153373d },
            { 632000.0d, 0.000000000105425d },
            { 634000.0d, 0.0000000000661758d },
            { 636000.0d, 0.000000000035833d },
            { 638000.0d, 0.0000000000146045d },
            { 640000.0d, 0.00000000000269657d },
            { 641500.0d, 0d },

        }; 
    }
}
    