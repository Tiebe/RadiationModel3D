using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium113";
        public override double halfLife { get; } = 93.0d;
        public override double atomicWeight { get; } = 112.91026d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver113()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0015d, new GammaParticle(43600.0, 0.02844)), new(0.0004d, new GammaParticle(49600.0, 0.025)), new(0.0001d, new GammaParticle(51500.0, 0.02407)), new(0.065d, new GammaParticle(95740.0, 0.01295)), new(0.005d, new GammaParticle(96000.0, 0.01292)), new(0.0034999999999999996d, new GammaParticle(147730.0, 0.00839)), new(0.0002d, new GammaParticle(178500.0, 0.00695)), new(0.0008d, new GammaParticle(205870.0, 0.00602)), new(0.024d, new GammaParticle(222060.0, 0.00558)), new(0.0027d, new GammaParticle(230490.0, 0.00538)), new(0.0043d, new GammaParticle(254610.0, 0.00487)), new(0.0027d, new GammaParticle(257100.0, 0.00482)), new(0.011000000000000001d, new GammaParticle(270810.0, 0.00458)), new(0.0004d, new GammaParticle(273600.0, 0.00453)), new(0.0021d, new GammaParticle(326280.0, 0.0038)), new(0.0011d, new GammaParticle(336300.0, 0.00369)), new(0.0004d, new GammaParticle(337320.0, 0.00368)), new(0.0066d, new GammaParticle(366800.0, 0.00338)), new(0.0028000000000000004d, new GammaParticle(386900.0, 0.0032)), new(0.0014000000000000002d, new GammaParticle(414900.0, 0.00299)), new(0.0011d, new GammaParticle(433400.0, 0.00286)), new(0.0011d, new GammaParticle(472100.0, 0.00263)), new(0.017d, new GammaParticle(482600.0, 0.00257)), new(0.0021d, new GammaParticle(510900.0, 0.00243)), new(0.0018d, new GammaParticle(534200.0, 0.00232)), new(0.016d, new GammaParticle(567700.0, 0.00218)), new(0.0023d, new GammaParticle(607000.0, 0.00204)), new(0.06d, new GammaParticle(643700.0, 0.00193)), new(0.0007000000000000001d, new GammaParticle(673200.0, 0.00184)), new(0.048d, new GammaParticle(739630.0, 0.00168)), new(0.0007000000000000001d, new GammaParticle(781900.0, 0.00159)), new(0.07d, new GammaParticle(3218.0, 0.38528)), new(0.04d, new GammaParticle(21990.0, 0.05638)), new(0.07d, new GammaParticle(22163.0, 0.05594)), new(0.021d, new GammaParticle(25030.0, 0.04953)), new(0.024d, new GammaParticle(25211.0, 0.04918)), new(0.0036d, new GammaParticle(25454.0, 0.04871)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000131429d },
            { 8000.0d, 0.000134445d },
            { 16000.0d, 0.00013745d },
            { 24000.0d, 0.000140442d },
            { 32000.0d, 0.000143444d },
            { 40000.0d, 0.000146515d },
            { 48000.0d, 0.000149657d },
            { 56000.0d, 0.000152865d },
            { 64000.0d, 0.000156134d },
            { 72000.0d, 0.000159455d },
            { 80000.0d, 0.000162821d },
            { 88000.0d, 0.000166225d },
            { 96000.0d, 0.000169664d },
            { 104000.0d, 0.000173131d },
            { 114000.0d, 0.000177499d },
            { 124000.0d, 0.0001819d },
            { 134000.0d, 0.000186326d },
            { 144000.0d, 0.000190774d },
            { 154000.0d, 0.00019524d },
            { 164000.0d, 0.00019972d },
            { 174000.0d, 0.000204211d },
            { 184000.0d, 0.00020871d },
            { 194000.0d, 0.000213216d },
            { 204000.0d, 0.000217723d },
            { 214000.0d, 0.000222232d },
            { 224000.0d, 0.000226741d },
            { 234000.0d, 0.000231247d },
            { 244000.0d, 0.000235748d },
            { 254000.0d, 0.000240243d },
            { 264000.0d, 0.000244731d },
            { 274000.0d, 0.00024921d },
            { 284000.0d, 0.000253678d },
            { 294000.0d, 0.000258134d },
            { 304000.0d, 0.000262578d },
            { 314000.0d, 0.000267008d },
            { 324000.0d, 0.000271422d },
            { 334000.0d, 0.000275818d },
            { 344000.0d, 0.000280198d },
            { 354000.0d, 0.000284558d },
            { 364000.0d, 0.000288898d },
            { 374000.0d, 0.000293216d },
            { 384000.0d, 0.000297512d },
            { 394000.0d, 0.000301786d },
            { 404000.0d, 0.000306035d },
            { 414000.0d, 0.000310259d },
            { 424000.0d, 0.000314456d },
            { 434000.0d, 0.000318627d },
            { 444000.0d, 0.000322769d },
            { 454000.0d, 0.000326883d },
            { 464000.0d, 0.000330967d },
            { 474000.0d, 0.00033502d },
            { 484000.0d, 0.000339041d },
            { 494000.0d, 0.000343031d },
            { 504000.0d, 0.000346987d },
            { 514000.0d, 0.00035091d },
            { 524000.0d, 0.000354797d },
            { 534000.0d, 0.000358648d },
            { 544000.0d, 0.000362465d },
            { 554000.0d, 0.000366243d },
            { 564000.0d, 0.000369985d },
            { 574000.0d, 0.000373687d },
            { 584000.0d, 0.000377351d },
            { 594000.0d, 0.000380975d },
            { 604000.0d, 0.000384559d },
            { 614000.0d, 0.000388101d },
            { 624000.0d, 0.000391602d },
            { 634000.0d, 0.00039506d },
            { 644000.0d, 0.000398476d },
            { 654000.0d, 0.000401848d },
            { 664000.0d, 0.000405175d },
            { 674000.0d, 0.000408459d },
            { 684000.0d, 0.000411696d },
            { 694000.0d, 0.000414889d },
            { 704000.0d, 0.000418034d },
            { 714000.0d, 0.000421133d },
            { 724000.0d, 0.000424185d },
            { 734000.0d, 0.000427189d },
            { 744000.0d, 0.000430144d },
            { 754000.0d, 0.000433051d },
            { 764000.0d, 0.000435908d },
            { 774000.0d, 0.000438716d },
            { 784000.0d, 0.000441473d },
            { 794000.0d, 0.00044418d },
            { 804000.0d, 0.000446836d },
            { 814000.0d, 0.00044944d },
            { 824000.0d, 0.000451993d },
            { 834000.0d, 0.000454493d },
            { 844000.0d, 0.000456942d },
            { 854000.0d, 0.000459336d },
            { 864000.0d, 0.000461678d },
            { 874000.0d, 0.000463966d },
            { 884000.0d, 0.000466201d },
            { 894000.0d, 0.000468381d },
            { 904000.0d, 0.000470507d },
            { 914000.0d, 0.000472577d },
            { 924000.0d, 0.000474593d },
            { 934000.0d, 0.000476554d },
            { 944000.0d, 0.000478459d },
            { 954000.0d, 0.000480307d },
            { 964000.0d, 0.0004821d },
            { 974000.0d, 0.000483838d },
            { 984000.0d, 0.000485518d },
            { 994000.0d, 0.000487141d },
            { 1004000.0d, 0.000488708d },
            { 1014000.0d, 0.000490218d },
            { 1024000.0d, 0.00049167d },
            { 1034000.0d, 0.000493065d },
            { 1044000.0d, 0.000494402d },
            { 1054000.0d, 0.000495682d },
            { 1064000.0d, 0.000496904d },
            { 1074000.0d, 0.000498068d },
            { 1084000.0d, 0.000499174d },
            { 1094000.0d, 0.000500222d },
            { 1104000.0d, 0.000501211d },
            { 1114000.0d, 0.000502142d },
            { 1124000.0d, 0.000503015d },
            { 1134000.0d, 0.000503829d },
            { 1144000.0d, 0.000504586d },
            { 1154000.0d, 0.000505283d },
            { 1164000.0d, 0.000505922d },
            { 1174000.0d, 0.000506503d },
            { 1184000.0d, 0.000507024d },
            { 1194000.0d, 0.000507488d },
            { 1204000.0d, 0.000507893d },
            { 1214000.0d, 0.000508239d },
            { 1224000.0d, 0.000508527d },
            { 1234000.0d, 0.000508756d },
            { 1244000.0d, 0.000508928d },
            { 1254000.0d, 0.000509041d },
            { 1264000.0d, 0.000509095d },
            { 1274000.0d, 0.000509091d },
            { 1284000.0d, 0.000509029d },
            { 1294000.0d, 0.000508909d },
            { 1304000.0d, 0.000508732d },
            { 1314000.0d, 0.000508497d },
            { 1324000.0d, 0.000508204d },
            { 1334000.0d, 0.000507854d },
            { 1344000.0d, 0.000507445d },
            { 1354000.0d, 0.000506981d },
            { 1364000.0d, 0.000506459d },
            { 1374000.0d, 0.000505881d },
            { 1384000.0d, 0.000505245d },
            { 1394000.0d, 0.000504554d },
            { 1404000.0d, 0.000503806d },
            { 1414000.0d, 0.000503002d },
            { 1424000.0d, 0.000502142d },
            { 1434000.0d, 0.000501227d },
            { 1444000.0d, 0.000500256d },
            { 1454000.0d, 0.000499231d },
            { 1464000.0d, 0.000498151d },
            { 1474000.0d, 0.000497016d },
            { 1484000.0d, 0.000495827d },
            { 1494000.0d, 0.000494584d },
            { 1504000.0d, 0.000493287d },
            { 1514000.0d, 0.000491937d },
            { 1524000.0d, 0.000490533d },
            { 1534000.0d, 0.000489078d },
            { 1544000.0d, 0.00048757d },
            { 1554000.0d, 0.00048601d },
            { 1564000.0d, 0.000484398d },
            { 1574000.0d, 0.000482734d },
            { 1584000.0d, 0.00048102d },
            { 1594000.0d, 0.000479255d },
            { 1604000.0d, 0.000477441d },
            { 1614000.0d, 0.000475575d },
            { 1624000.0d, 0.000473661d },
            { 1634000.0d, 0.000471698d },
            { 1644000.0d, 0.000469687d },
            { 1654000.0d, 0.000467628d },
            { 1664000.0d, 0.00046552d },
            { 1674000.0d, 0.000463366d },
            { 1684000.0d, 0.000461164d },
            { 1694000.0d, 0.000458916d },
            { 1704000.0d, 0.000456623d },
            { 1714000.0d, 0.000454284d },
            { 1724000.0d, 0.000451901d },
            { 1734000.0d, 0.000449473d },
            { 1744000.0d, 0.000447001d },
            { 1754000.0d, 0.000444486d },
            { 1764000.0d, 0.000441929d },
            { 1774000.0d, 0.000439328d },
            { 1784000.0d, 0.000436686d },
            { 1794000.0d, 0.000434004d },
            { 1804000.0d, 0.00043128d },
            { 1814000.0d, 0.000428516d },
            { 1824000.0d, 0.000425714d },
            { 1834000.0d, 0.000422872d },
            { 1844000.0d, 0.000419992d },
            { 1854000.0d, 0.000417074d },
            { 1864000.0d, 0.00041412d },
            { 1874000.0d, 0.000411129d },
            { 1884000.0d, 0.000408102d },
            { 1894000.0d, 0.00040504d },
            { 1904000.0d, 0.000401943d },
            { 1914000.0d, 0.000398813d },
            { 1924000.0d, 0.000395649d },
            { 1934000.0d, 0.000392454d },
            { 1944000.0d, 0.000389226d },
            { 1954000.0d, 0.000385968d },
            { 1964000.0d, 0.000382678d },
            { 1974000.0d, 0.000379359d },
            { 1984000.0d, 0.000376011d },
            { 1994000.0d, 0.000372635d },
            { 2004000.0d, 0.000369232d },
            { 2014000.0d, 0.000365801d },
            { 2024000.0d, 0.000362344d },
            { 2034000.0d, 0.000358862d },
            { 2044000.0d, 0.000355356d },
            { 2054000.0d, 0.000351826d },
            { 2064000.0d, 0.000348273d },
            { 2074000.0d, 0.000344697d },
            { 2084000.0d, 0.0003411d },
            { 2094000.0d, 0.000337483d },
            { 2104000.0d, 0.000333846d },
            { 2114000.0d, 0.00033019d },
            { 2124000.0d, 0.000326516d },
            { 2134000.0d, 0.000322824d },
            { 2144000.0d, 0.000319117d },
            { 2154000.0d, 0.000315394d },
            { 2164000.0d, 0.000311656d },
            { 2174000.0d, 0.000307904d },
            { 2184000.0d, 0.000304139d },
            { 2194000.0d, 0.000300362d },
            { 2204000.0d, 0.000296574d },
            { 2214000.0d, 0.000292776d },
            { 2224000.0d, 0.000288968d },
            { 2234000.0d, 0.000285152d },
            { 2244000.0d, 0.000281328d },
            { 2254000.0d, 0.000277499d },
            { 2264000.0d, 0.000273663d },
            { 2274000.0d, 0.000269823d },
            { 2284000.0d, 0.000265978d },
            { 2294000.0d, 0.000262131d },
            { 2304000.0d, 0.000258283d },
            { 2314000.0d, 0.000254434d },
            { 2324000.0d, 0.000250585d },
            { 2334000.0d, 0.000246737d },
            { 2344000.0d, 0.000242891d },
            { 2354000.0d, 0.000239049d },
            { 2364000.0d, 0.000235211d },
            { 2374000.0d, 0.000231378d },
            { 2384000.0d, 0.000227552d },
            { 2394000.0d, 0.000223732d },
            { 2404000.0d, 0.000219922d },
            { 2414000.0d, 0.000216121d },
            { 2424000.0d, 0.00021233d },
            { 2434000.0d, 0.000208552d },
            { 2444000.0d, 0.000204785d },
            { 2454000.0d, 0.000201033d },
            { 2464000.0d, 0.000197296d },
            { 2474000.0d, 0.000193575d },
            { 2484000.0d, 0.000189871d },
            { 2494000.0d, 0.000186186d },
            { 2504000.0d, 0.000182519d },
            { 2514000.0d, 0.000178873d },
            { 2524000.0d, 0.000175249d },
            { 2534000.0d, 0.000171648d },
            { 2544000.0d, 0.000168071d },
            { 2554000.0d, 0.000164518d },
            { 2564000.0d, 0.000160989d },
            { 2574000.0d, 0.000157473d },
            { 2584000.0d, 0.00015397d },
            { 2594000.0d, 0.000150482d },
            { 2604000.0d, 0.000147008d },
            { 2614000.0d, 0.000143552d },
            { 2624000.0d, 0.000140113d },
            { 2634000.0d, 0.000136692d },
            { 2644000.0d, 0.00013329d },
            { 2654000.0d, 0.00012991d },
            { 2664000.0d, 0.00012655d },
            { 2674000.0d, 0.000123212d },
            { 2684000.0d, 0.000119897d },
            { 2694000.0d, 0.000116605d },
            { 2704000.0d, 0.000113339d },
            { 2714000.0d, 0.000110098d },
            { 2724000.0d, 0.000106884d },
            { 2734000.0d, 0.000103698d },
            { 2744000.0d, 0.000100539d },
            { 2754000.0d, 0.0000974103d },
            { 2764000.0d, 0.0000943115d },
            { 2774000.0d, 0.0000912439d },
            { 2784000.0d, 0.0000882085d },
            { 2794000.0d, 0.0000852065d },
            { 2804000.0d, 0.0000822389d },
            { 2814000.0d, 0.0000793067d },
            { 2824000.0d, 0.0000764111d },
            { 2834000.0d, 0.0000735531d },
            { 2844000.0d, 0.0000707337d },
            { 2854000.0d, 0.0000679541d },
            { 2864000.0d, 0.0000652155d },
            { 2874000.0d, 0.0000625183d },
            { 2884000.0d, 0.0000598633d },
            { 2894000.0d, 0.0000572518d },
            { 2904000.0d, 0.0000546846d },
            { 2914000.0d, 0.0000521631d },
            { 2924000.0d, 0.0000496882d },
            { 2934000.0d, 0.0000472613d },
            { 2944000.0d, 0.0000448833d },
            { 2954000.0d, 0.0000425553d },
            { 2964000.0d, 0.0000402787d },
            { 2974000.0d, 0.0000380544d },
            { 2984000.0d, 0.000035882d },
            { 2994000.0d, 0.0000337621d },
            { 3004000.0d, 0.0000316958d },
            { 3014000.0d, 0.0000296842d },
            { 3024000.0d, 0.0000277286d },
            { 3034000.0d, 0.0000258299d },
            { 3044000.0d, 0.0000239896d },
            { 3054000.0d, 0.0000222087d },
            { 3064000.0d, 0.0000204882d },
            { 3074000.0d, 0.0000188295d },
            { 3084000.0d, 0.0000172337d },
            { 3094000.0d, 0.0000157021d },
            { 3104000.0d, 0.0000142357d },
            { 3114000.0d, 0.0000128358d },
            { 3124000.0d, 0.0000115034d },
            { 3134000.0d, 0.0000102386d },
            { 3144000.0d, 0.00000904264d },
            { 3154000.0d, 0.00000791665d },
            { 3164000.0d, 0.00000686182d },
            { 3174000.0d, 0.00000587937d },
            { 3184000.0d, 0.00000497048d },
            { 3194000.0d, 0.00000413634d },
            { 3204000.0d, 0.00000337797d },
            { 3214000.0d, 0.00000269408d },
            { 3224000.0d, 0.00000208492d },
            { 3234000.0d, 0.00000155158d },
            { 3244000.0d, 0.00000109512d },
            { 3254000.0d, 0.000000716602d },
            { 3264000.0d, 0.000000417055d },
            { 3274000.0d, 0.000000197468d },
            { 3284000.0d, 0.0000000587533d },
            { 3294000.0d, 0.0000000016073d },
            { 3296000.0d, 0d },

        }; 
    }
}
    