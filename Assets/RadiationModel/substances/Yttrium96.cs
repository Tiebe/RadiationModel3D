using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium96";
        public override double halfLife { get; } = 5.34d;
        public override double atomicWeight { get; } = 95.91591d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zirconium96()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0007520000000000001d, new GammaParticle(146653.0, 0.00845)), new(0.00051935d, new GammaParticle(328700.0, 0.00377)), new(0.0017155d, new GammaParticle(469500.0, 0.00264)), new(0.00188d, new GammaParticle(475300.0, 0.00261)), new(0.0007049999999999999d, new GammaParticle(644400.0, 0.00192)), new(0.0001786d, new GammaParticle(699900.0, 0.00177)), new(0.0001504d, new GammaParticle(771700.0, 0.00161)), new(0.00047d, new GammaParticle(781200.0, 0.00159)), new(0.0007520000000000001d, new GammaParticle(918500.0, 0.00135)), new(0.0004465d, new GammaParticle(1175000.0, 0.00106)), new(5.64e-05d, new GammaParticle(1225200.0, 0.00101)), new(7.755e-05d, new GammaParticle(1315000.0, 0.00094)), new(0.00012925d, new GammaParticle(1332400.0, 0.00093)), new(6.815e-05d, new GammaParticle(1462000.0, 0.00085)), new(1.88e-05d, new GammaParticle(1612100.0, 0.00077)), new(0.000235d, new GammaParticle(1625800.0, 0.00076)), new(0.00028199999999999997d, new GammaParticle(1699600.0, 0.00073)), new(0.0235d, new GammaParticle(1750400.0, 0.00071)), new(0.00014099999999999998d, new GammaParticle(1897400.0, 0.00065)), new(8.225e-05d, new GammaParticle(1912100.0, 0.00065)), new(3.5249999999999996e-05d, new GammaParticle(1956300.0, 0.00063)), new(0.0032195d, new GammaParticle(2225600.0, 0.00056)), new(5.17e-05d, new GammaParticle(2274000.0, 0.00055)), new(0.00014099999999999998d, new GammaParticle(2940000.0, 0.00042)), new(0.00010575d, new GammaParticle(3086900.0, 0.0004)), new(6.815e-05d, new GammaParticle(3212900.0, 0.00039)), new(8.460000000000001e-05d, new GammaParticle(3257400.0, 0.00038)), new(3.29e-05d, new GammaParticle(3615200.0, 0.00034)), new(0.0001175d, new GammaParticle(3701000.0, 0.00034)), new(0.0001457d, new GammaParticle(3730800.0, 0.00033)), new(0.0001316d, new GammaParticle(3826600.0, 0.00032)), new(0.00028199999999999997d, new GammaParticle(3861700.0, 0.00032)), new(4.465e-05d, new GammaParticle(3992200.0, 0.00031)), new(3.995e-05d, new GammaParticle(4044200.0, 0.00031)), new(3.29e-05d, new GammaParticle(4071200.0, 0.0003)), new(0.0001034d, new GammaParticle(4119600.0, 0.0003)), new(2.1150000000000002e-05d, new GammaParticle(4159800.0, 0.0003)), new(0.0001363d, new GammaParticle(4162900.0, 0.0003)), new(2.585e-05d, new GammaParticle(4334200.0, 0.00029)), new(0.00011044999999999999d, new GammaParticle(4512400.0, 0.00027)), new(2.1150000000000002e-05d, new GammaParticle(4562700.0, 0.00027)), new(0.00010575d, new GammaParticle(4737400.0, 0.00026)), new(0.00023735d, new GammaParticle(4839200.0, 0.00026)), new(0.00031489999999999996d, new GammaParticle(4895100.0, 0.00025)), new(9.164999999999999e-05d, new GammaParticle(4914000.0, 0.00025)), new(0.00022089999999999998d, new GammaParticle(4929000.0, 0.00025)), new(0.00012925d, new GammaParticle(5228300.0, 0.00024)), new(0.00014335000000000001d, new GammaParticle(5271800.0, 0.00024)), new(0.00010104999999999999d, new GammaParticle(5442500.0, 0.00023)), new(0.0001222d, new GammaParticle(5502000.0, 0.00023)), new(0.00010575d, new GammaParticle(5538700.0, 0.00022)), new(0.0004465d, new GammaParticle(5551400.0, 0.00022)), new(6.11e-05d, new GammaParticle(5573700.0, 0.00022)), new(0.00033840000000000004d, new GammaParticle(5601300.0, 0.00022)), new(0.00024205d, new GammaParticle(5718900.0, 0.00022)), new(3.76e-05d, new GammaParticle(5782900.0, 0.00021)), new(8.93e-05d, new GammaParticle(5804300.0, 0.00021)), new(6.345e-05d, new GammaParticle(5838100.0, 0.00021)), new(0.00014805d, new GammaParticle(5847300.0, 0.00021)), new(0.0001316d, new GammaParticle(5914900.0, 0.00021)), new(0.00028670000000000003d, new GammaParticle(5934400.0, 0.00021)), new(3.5249999999999996e-05d, new GammaParticle(6141600.0, 0.0002)), new(8.225e-05d, new GammaParticle(6231400.0, 0.0002)), new(1.74893016812113e-06d, new GammaParticle(2161.0, 0.57374)), new(9.928592976666086e-06d, new GammaParticle(15691.0, 0.07902)), new(1.90020918213705e-05d, new GammaParticle(15775.0, 0.0786)), new(4.841976740194955e-06d, new GammaParticle(17736.0, 0.06991)), new(5.548905344263417e-06d, new GammaParticle(17824.0, 0.06956)), new(7.069286040684635e-07d, new GammaParticle(17968.0, 0.069)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000212635d },
            { 2000.0d, 0.0000213879d },
            { 4000.0d, 0.0000215126d },
            { 6000.0d, 0.0000216378d },
            { 8000.0d, 0.0000217637d },
            { 10000.0d, 0.0000218903d },
            { 12000.0d, 0.000022018d },
            { 14000.0d, 0.0000221467d },
            { 16000.0d, 0.0000222764d },
            { 18000.0d, 0.0000224074d },
            { 20000.0d, 0.0000225395d },
            { 22000.0d, 0.0000226728d },
            { 24000.0d, 0.0000228075d },
            { 26000.0d, 0.0000229434d },
            { 28000.0d, 0.0000230805d },
            { 30000.0d, 0.000023219d },
            { 32000.0d, 0.0000233587d },
            { 34000.0d, 0.0000234998d },
            { 36000.0d, 0.0000236421d },
            { 38000.0d, 0.0000237856d },
            { 40000.0d, 0.0000239304d },
            { 42000.0d, 0.0000240765d },
            { 44000.0d, 0.0000242237d },
            { 46000.0d, 0.0000243723d },
            { 48000.0d, 0.000024522d },
            { 50000.0d, 0.0000246729d },
            { 52000.0d, 0.000024825d },
            { 54000.0d, 0.0000249782d },
            { 56000.0d, 0.0000251326d },
            { 58000.0d, 0.0000252881d },
            { 60000.0d, 0.0000254447d },
            { 62000.0d, 0.0000256025d },
            { 64000.0d, 0.0000257614d },
            { 66000.0d, 0.0000259215d },
            { 68000.0d, 0.0000260826d },
            { 70000.0d, 0.0000262438d },
            { 72000.0d, 0.0000264047d },
            { 74000.0d, 0.0000265663d },
            { 76000.0d, 0.0000267287d },
            { 78000.0d, 0.0000268918d },
            { 80000.0d, 0.0000270556d },
            { 82000.0d, 0.0000272202d },
            { 84000.0d, 0.0000273855d },
            { 86000.0d, 0.0000275514d },
            { 88000.0d, 0.000027718d },
            { 90000.0d, 0.0000278854d },
            { 92000.0d, 0.0000280534d },
            { 94000.0d, 0.0000282209d },
            { 96000.0d, 0.0000283889d },
            { 98000.0d, 0.0000285575d },
            { 100000.0d, 0.0000287265d },
            { 110000.0d, 0.0000295788d },
            { 120000.0d, 0.0000304412d },
            { 130000.0d, 0.0000313118d },
            { 140000.0d, 0.0000321909d },
            { 150000.0d, 0.0000330767d },
            { 160000.0d, 0.0000339696d },
            { 170000.0d, 0.0000348685d },
            { 180000.0d, 0.0000357735d },
            { 190000.0d, 0.000036684d },
            { 200000.0d, 0.0000375998d },
            { 210000.0d, 0.0000385207d },
            { 220000.0d, 0.0000394462d },
            { 230000.0d, 0.0000403765d },
            { 240000.0d, 0.0000413108d },
            { 250000.0d, 0.0000422494d },
            { 260000.0d, 0.000043192d },
            { 270000.0d, 0.0000441384d },
            { 280000.0d, 0.0000450886d },
            { 290000.0d, 0.0000460421d },
            { 300000.0d, 0.0000469991d },
            { 310000.0d, 0.0000479593d },
            { 320000.0d, 0.0000489226d },
            { 330000.0d, 0.0000498888d },
            { 340000.0d, 0.0000508579d },
            { 350000.0d, 0.0000518297d },
            { 360000.0d, 0.000052804d },
            { 370000.0d, 0.000053781d },
            { 380000.0d, 0.0000547602d },
            { 390000.0d, 0.0000557418d },
            { 400000.0d, 0.0000567255d },
            { 410000.0d, 0.0000577112d },
            { 420000.0d, 0.000058699d },
            { 430000.0d, 0.0000596886d },
            { 440000.0d, 0.0000606801d },
            { 450000.0d, 0.0000616731d },
            { 460000.0d, 0.0000626679d },
            { 470000.0d, 0.0000636641d },
            { 480000.0d, 0.0000646617d },
            { 490000.0d, 0.0000656607d },
            { 500000.0d, 0.000066661d },
            { 510000.0d, 0.0000676625d },
            { 520000.0d, 0.000068665d },
            { 530000.0d, 0.0000696686d },
            { 540000.0d, 0.0000706731d },
            { 550000.0d, 0.0000716786d },
            { 560000.0d, 0.0000726848d },
            { 570000.0d, 0.0000736919d },
            { 580000.0d, 0.0000746996d },
            { 590000.0d, 0.0000757079d },
            { 600000.0d, 0.0000767168d },
            { 610000.0d, 0.0000777262d },
            { 620000.0d, 0.0000787361d },
            { 630000.0d, 0.0000797464d },
            { 640000.0d, 0.000080757d },
            { 650000.0d, 0.000081768d },
            { 660000.0d, 0.0000827792d },
            { 670000.0d, 0.0000837906d },
            { 680000.0d, 0.0000848021d },
            { 690000.0d, 0.0000858138d },
            { 700000.0d, 0.0000868254d },
            { 710000.0d, 0.0000878372d },
            { 720000.0d, 0.0000888488d },
            { 730000.0d, 0.0000898605d },
            { 740000.0d, 0.0000908721d },
            { 750000.0d, 0.0000918835d },
            { 760000.0d, 0.0000928949d },
            { 770000.0d, 0.0000939059d },
            { 780000.0d, 0.0000949169d },
            { 790000.0d, 0.0000959275d },
            { 800000.0d, 0.000096938d },
            { 810000.0d, 0.0000979481d },
            { 820000.0d, 0.0000989579d },
            { 830000.0d, 0.0000999675d },
            { 840000.0d, 0.000100977d },
            { 850000.0d, 0.000101985d },
            { 860000.0d, 0.000102994d },
            { 870000.0d, 0.000104002d },
            { 880000.0d, 0.000105009d },
            { 890000.0d, 0.000106016d },
            { 900000.0d, 0.000107022d },
            { 910000.0d, 0.000108027d },
            { 920000.0d, 0.000109031d },
            { 930000.0d, 0.000110035d },
            { 940000.0d, 0.000111038d },
            { 950000.0d, 0.00011204d },
            { 960000.0d, 0.000113041d },
            { 970000.0d, 0.000114042d },
            { 980000.0d, 0.000115041d },
            { 990000.0d, 0.00011604d },
            { 1000000.0d, 0.000117038d },
            { 1023000.0d, 0.000119329d },
            { 1046000.0d, 0.000121616d },
            { 1069000.0d, 0.000123898d },
            { 1092000.0d, 0.000126174d },
            { 1115000.0d, 0.000128445d },
            { 1138000.0d, 0.000130712d },
            { 1161000.0d, 0.000132974d },
            { 1184000.0d, 0.000135231d },
            { 1207000.0d, 0.000137479d },
            { 1230000.0d, 0.000139719d },
            { 1253000.0d, 0.00014195d },
            { 1276000.0d, 0.00014417d },
            { 1299000.0d, 0.000146379d },
            { 1322000.0d, 0.000148578d },
            { 1345000.0d, 0.000150765d },
            { 1368000.0d, 0.00015294d },
            { 1391000.0d, 0.000155104d },
            { 1414000.0d, 0.000157254d },
            { 1437000.0d, 0.00015939d },
            { 1460000.0d, 0.000161511d },
            { 1483000.0d, 0.00016362d },
            { 1506000.0d, 0.000165713d },
            { 1529000.0d, 0.00016779d },
            { 1552000.0d, 0.000169851d },
            { 1575000.0d, 0.000171894d },
            { 1598000.0d, 0.000173917d },
            { 1621000.0d, 0.00017592d },
            { 1644000.0d, 0.000177903d },
            { 1667000.0d, 0.000179866d },
            { 1690000.0d, 0.000181808d },
            { 1713000.0d, 0.000183728d },
            { 1736000.0d, 0.000185624d },
            { 1759000.0d, 0.000187498d },
            { 1782000.0d, 0.000189348d },
            { 1805000.0d, 0.000191174d },
            { 1828000.0d, 0.000192976d },
            { 1851000.0d, 0.000194753d },
            { 1874000.0d, 0.000196506d },
            { 1897000.0d, 0.000198232d },
            { 1920000.0d, 0.000199932d },
            { 1943000.0d, 0.000201606d },
            { 1966000.0d, 0.000203253d },
            { 1989000.0d, 0.000204873d },
            { 2012000.0d, 0.000206466d },
            { 2035000.0d, 0.000208031d },
            { 2058000.0d, 0.00020957d },
            { 2081000.0d, 0.000211079d },
            { 2104000.0d, 0.000212562d },
            { 2127000.0d, 0.000214015d },
            { 2150000.0d, 0.00021544d },
            { 2173000.0d, 0.000216836d },
            { 2196000.0d, 0.000218204d },
            { 2219000.0d, 0.000219541d },
            { 2242000.0d, 0.000220849d },
            { 2265000.0d, 0.000222127d },
            { 2288000.0d, 0.000223372d },
            { 2311000.0d, 0.000224586d },
            { 2334000.0d, 0.000225768d },
            { 2357000.0d, 0.000226916d },
            { 2380000.0d, 0.000228033d },
            { 2403000.0d, 0.000229116d },
            { 2426000.0d, 0.000230166d },
            { 2449000.0d, 0.000231182d },
            { 2472000.0d, 0.000232165d },
            { 2495000.0d, 0.000233113d },
            { 2518000.0d, 0.000234028d },
            { 2541000.0d, 0.00023491d },
            { 2564000.0d, 0.000235757d },
            { 2587000.0d, 0.000236569d },
            { 2610000.0d, 0.000237347d },
            { 2633000.0d, 0.00023809d },
            { 2656000.0d, 0.000238798d },
            { 2679000.0d, 0.000239471d },
            { 2702000.0d, 0.00024011d },
            { 2725000.0d, 0.000240714d },
            { 2748000.0d, 0.000241282d },
            { 2771000.0d, 0.000241815d },
            { 2794000.0d, 0.000242312d },
            { 2817000.0d, 0.000242775d },
            { 2840000.0d, 0.000243201d },
            { 2863000.0d, 0.000243593d },
            { 2886000.0d, 0.00024395d },
            { 2909000.0d, 0.00024427d },
            { 2932000.0d, 0.000244554d },
            { 2955000.0d, 0.000244802d },
            { 2978000.0d, 0.000245015d },
            { 3001000.0d, 0.000245192d },
            { 3024000.0d, 0.000245333d },
            { 3047000.0d, 0.000245438d },
            { 3070000.0d, 0.000245508d },
            { 3093000.0d, 0.000245541d },
            { 3116000.0d, 0.00024554d },
            { 3139000.0d, 0.000245502d },
            { 3162000.0d, 0.000245428d },
            { 3185000.0d, 0.00024532d },
            { 3208000.0d, 0.000245175d },
            { 3231000.0d, 0.000244995d },
            { 3254000.0d, 0.00024478d },
            { 3277000.0d, 0.000244529d },
            { 3300000.0d, 0.000244242d },
            { 3323000.0d, 0.000243922d },
            { 3346000.0d, 0.000243565d },
            { 3369000.0d, 0.000243174d },
            { 3392000.0d, 0.000242749d },
            { 3415000.0d, 0.000242288d },
            { 3438000.0d, 0.000241793d },
            { 3461000.0d, 0.000241263d },
            { 3484000.0d, 0.0002407d },
            { 3507000.0d, 0.000240102d },
            { 3530000.0d, 0.00023947d },
            { 3553000.0d, 0.000238805d },
            { 3576000.0d, 0.000238106d },
            { 3599000.0d, 0.000237373d },
            { 3622000.0d, 0.000236607d },
            { 3645000.0d, 0.000235808d },
            { 3668000.0d, 0.000234977d },
            { 3691000.0d, 0.000234113d },
            { 3714000.0d, 0.000233215d },
            { 3737000.0d, 0.000232286d },
            { 3760000.0d, 0.000231324d },
            { 3783000.0d, 0.000230331d },
            { 3806000.0d, 0.000229306d },
            { 3829000.0d, 0.00022825d },
            { 3852000.0d, 0.000227162d },
            { 3875000.0d, 0.000226044d },
            { 3898000.0d, 0.000224895d },
            { 3921000.0d, 0.000223716d },
            { 3944000.0d, 0.000222507d },
            { 3967000.0d, 0.000221268d },
            { 3990000.0d, 0.00022d },
            { 4013000.0d, 0.000218704d },
            { 4036000.0d, 0.00021738d },
            { 4059000.0d, 0.000216026d },
            { 4082000.0d, 0.000214645d },
            { 4105000.0d, 0.000213237d },
            { 4128000.0d, 0.000211802d },
            { 4151000.0d, 0.00021034d },
            { 4174000.0d, 0.000208852d },
            { 4197000.0d, 0.000207338d },
            { 4220000.0d, 0.000205799d },
            { 4243000.0d, 0.000204234d },
            { 4266000.0d, 0.000202645d },
            { 4289000.0d, 0.000201032d },
            { 4312000.0d, 0.000199395d },
            { 4335000.0d, 0.000197736d },
            { 4358000.0d, 0.000196053d },
            { 4381000.0d, 0.000194349d },
            { 4404000.0d, 0.000192622d },
            { 4427000.0d, 0.000190875d },
            { 4450000.0d, 0.000189106d },
            { 4473000.0d, 0.000187317d },
            { 4496000.0d, 0.000185507d },
            { 4519000.0d, 0.000183678d },
            { 4542000.0d, 0.000181829d },
            { 4565000.0d, 0.000179963d },
            { 4588000.0d, 0.000178078d },
            { 4611000.0d, 0.000176176d },
            { 4634000.0d, 0.000174257d },
            { 4657000.0d, 0.000172322d },
            { 4680000.0d, 0.000170372d },
            { 4703000.0d, 0.000168407d },
            { 4726000.0d, 0.000166427d },
            { 4749000.0d, 0.000164435d },
            { 4772000.0d, 0.000162429d },
            { 4795000.0d, 0.00016041d },
            { 4818000.0d, 0.000158381d },
            { 4841000.0d, 0.00015634d },
            { 4864000.0d, 0.00015429d },
            { 4887000.0d, 0.000152229d },
            { 4910000.0d, 0.000150159d },
            { 4933000.0d, 0.000148079d },
            { 4956000.0d, 0.00014599d },
            { 4979000.0d, 0.000143893d },
            { 5002000.0d, 0.000141789d },
            { 5025000.0d, 0.000139678d },
            { 5048000.0d, 0.000137561d },
            { 5071000.0d, 0.00013544d },
            { 5094000.0d, 0.000133313d },
            { 5117000.0d, 0.000131183d },
            { 5140000.0d, 0.00012905d },
            { 5163000.0d, 0.000126915d },
            { 5186000.0d, 0.000124778d },
            { 5209000.0d, 0.000122641d },
            { 5232000.0d, 0.000120504d },
            { 5255000.0d, 0.000118368d },
            { 5278000.0d, 0.000116234d },
            { 5301000.0d, 0.000114103d },
            { 5324000.0d, 0.000111975d },
            { 5347000.0d, 0.000109851d },
            { 5370000.0d, 0.00010773d },
            { 5393000.0d, 0.00010561d },
            { 5416000.0d, 0.000103492d },
            { 5439000.0d, 0.000101377d },
            { 5462000.0d, 0.0000992642d },
            { 5485000.0d, 0.0000971556d },
            { 5508000.0d, 0.0000950517d },
            { 5531000.0d, 0.0000929527d },
            { 5554000.0d, 0.000090858d },
            { 5577000.0d, 0.0000887683d },
            { 5600000.0d, 0.0000866843d },
            { 5623000.0d, 0.0000846066d },
            { 5646000.0d, 0.0000825361d },
            { 5669000.0d, 0.0000804733d },
            { 5692000.0d, 0.0000784189d },
            { 5715000.0d, 0.0000763738d },
            { 5738000.0d, 0.0000743385d },
            { 5761000.0d, 0.0000723139d },
            { 5784000.0d, 0.0000703005d },
            { 5807000.0d, 0.0000682992d },
            { 5830000.0d, 0.0000663107d },
            { 5853000.0d, 0.0000643357d },
            { 5876000.0d, 0.0000623749d },
            { 5899000.0d, 0.0000604292d },
            { 5922000.0d, 0.0000584992d },
            { 5945000.0d, 0.0000565858d },
            { 5968000.0d, 0.0000546897d },
            { 5991000.0d, 0.0000528116d },
            { 6014000.0d, 0.0000509523d },
            { 6037000.0d, 0.0000491127d },
            { 6060000.0d, 0.0000472934d },
            { 6083000.0d, 0.0000454953d },
            { 6106000.0d, 0.0000437192d },
            { 6129000.0d, 0.0000419658d },
            { 6152000.0d, 0.0000402359d },
            { 6175000.0d, 0.0000385305d },
            { 6198000.0d, 0.0000368501d },
            { 6221000.0d, 0.0000351958d },
            { 6244000.0d, 0.0000335683d },
            { 6267000.0d, 0.0000319684d },
            { 6290000.0d, 0.0000303969d },
            { 6313000.0d, 0.0000288548d },
            { 6336000.0d, 0.0000273427d },
            { 6359000.0d, 0.0000258616d },
            { 6382000.0d, 0.0000244122d },
            { 6405000.0d, 0.0000229955d },
            { 6428000.0d, 0.0000216124d },
            { 6451000.0d, 0.0000202636d },
            { 6474000.0d, 0.0000189499d },
            { 6497000.0d, 0.0000176724d },
            { 6520000.0d, 0.0000164318d },
            { 6543000.0d, 0.0000152289d },
            { 6566000.0d, 0.0000140648d },
            { 6589000.0d, 0.0000129402d },
            { 6612000.0d, 0.000011856d },
            { 6635000.0d, 0.0000108132d },
            { 6658000.0d, 0.00000981262d },
            { 6681000.0d, 0.00000885508d },
            { 6704000.0d, 0.00000794151d },
            { 6727000.0d, 0.00000707281d },
            { 6750000.0d, 0.00000624987d },
            { 6773000.0d, 0.0000054736d },
            { 6796000.0d, 0.00000474486d },
            { 6819000.0d, 0.00000406457d },
            { 6842000.0d, 0.00000343363d },
            { 6865000.0d, 0.00000285292d },
            { 6888000.0d, 0.00000232333d },
            { 6911000.0d, 0.00000184577d },
            { 6934000.0d, 0.00000142109d },
            { 6957000.0d, 0.00000105019d },
            { 6980000.0d, 0.000000733926d },
            { 7003000.0d, 0.000000473137d },
            { 7026000.0d, 0.000000268645d },
            { 7049000.0d, 0.000000121219d },
            { 7072000.0d, 0.0000000315418d },
            { 7095000.0d, 0.0000000000475498d },
            { 7096000.0d, 0d },

        }; 
    }
}
    