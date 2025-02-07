using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iodine136 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine136";
        public override double halfLife { get; } = 83.4d;
        public override double atomicWeight { get; } = 135.9146d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon136()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.000159224d },
            { 800.0d, 0.000156491d },
            { 1600.0d, 0.000155067d },
            { 2400.0d, 0.000154952d },
            { 3200.0d, 0.000155009d },
            { 4000.0d, 0.00015508d },
            { 4800.0d, 0.000155145d },
            { 5600.0d, 0.000155203d },
            { 6400.0d, 0.000155251d },
            { 7200.0d, 0.000155291d },
            { 8000.0d, 0.000155324d },
            { 8800.0d, 0.000155353d },
            { 9600.0d, 0.000155379d },
            { 10000.0d, 0.000155391d },
            { 11000.0d, 0.000155418d },
            { 12000.0d, 0.000155442d },
            { 13000.0d, 0.000155464d },
            { 14000.0d, 0.000155483d },
            { 15000.0d, 0.0001555d },
            { 16000.0d, 0.000155515d },
            { 17000.0d, 0.000155529d },
            { 18000.0d, 0.00015554d },
            { 19000.0d, 0.00015555d },
            { 20000.0d, 0.000155559d },
            { 21000.0d, 0.000155566d },
            { 22000.0d, 0.000155572d },
            { 23000.0d, 0.000155577d },
            { 24000.0d, 0.00015558d },
            { 25000.0d, 0.000155582d },
            { 26000.0d, 0.000155584d },
            { 27000.0d, 0.000155585d },
            { 28000.0d, 0.000155585d },
            { 29000.0d, 0.000155584d },
            { 30000.0d, 0.000155582d },
            { 31000.0d, 0.00015558d },
            { 32000.0d, 0.000155577d },
            { 33000.0d, 0.000155573d },
            { 34000.0d, 0.000155569d },
            { 35000.0d, 0.000155564d },
            { 36000.0d, 0.000155559d },
            { 37000.0d, 0.000155553d },
            { 38000.0d, 0.000155547d },
            { 39000.0d, 0.00015554d },
            { 40000.0d, 0.000155533d },
            { 41000.0d, 0.000155526d },
            { 42000.0d, 0.000155518d },
            { 43000.0d, 0.000155511d },
            { 44000.0d, 0.000155504d },
            { 45000.0d, 0.000155497d },
            { 46000.0d, 0.000155489d },
            { 47000.0d, 0.000155481d },
            { 48000.0d, 0.000155474d },
            { 49000.0d, 0.000155466d },
            { 50000.0d, 0.000155458d },
            { 51000.0d, 0.00015545d },
            { 52000.0d, 0.000155441d },
            { 53000.0d, 0.000155433d },
            { 54000.0d, 0.000155425d },
            { 55000.0d, 0.000155417d },
            { 56000.0d, 0.000155409d },
            { 57000.0d, 0.000155401d },
            { 58000.0d, 0.000155393d },
            { 59000.0d, 0.000155385d },
            { 60000.0d, 0.000155377d },
            { 61000.0d, 0.000155369d },
            { 62000.0d, 0.000155361d },
            { 63000.0d, 0.000155353d },
            { 64000.0d, 0.000155345d },
            { 65000.0d, 0.000155338d },
            { 66000.0d, 0.00015533d },
            { 67000.0d, 0.000155323d },
            { 68000.0d, 0.000155315d },
            { 69000.0d, 0.000155308d },
            { 70000.0d, 0.0001553d },
            { 71000.0d, 0.000155293d },
            { 72000.0d, 0.000155286d },
            { 73000.0d, 0.000155279d },
            { 74000.0d, 0.000155272d },
            { 75000.0d, 0.000155265d },
            { 76000.0d, 0.000155258d },
            { 77000.0d, 0.000155251d },
            { 78000.0d, 0.000155245d },
            { 79000.0d, 0.000155238d },
            { 80000.0d, 0.000155232d },
            { 81000.0d, 0.000155226d },
            { 82000.0d, 0.00015522d },
            { 83000.0d, 0.000155214d },
            { 84000.0d, 0.000155209d },
            { 85000.0d, 0.000155203d },
            { 86000.0d, 0.000155198d },
            { 87000.0d, 0.000155192d },
            { 88000.0d, 0.000155187d },
            { 89000.0d, 0.000155182d },
            { 90000.0d, 0.000155178d },
            { 91000.0d, 0.000155173d },
            { 92000.0d, 0.000155169d },
            { 93000.0d, 0.000155165d },
            { 94000.0d, 0.000155161d },
            { 95000.0d, 0.000155157d },
            { 96000.0d, 0.000155154d },
            { 97000.0d, 0.000155151d },
            { 98000.0d, 0.000155148d },
            { 99000.0d, 0.000155146d },
            { 100000.0d, 0.000155143d },
            { 110000.0d, 0.000155136d },
            { 120000.0d, 0.000155166d },
            { 130000.0d, 0.000155243d },
            { 140000.0d, 0.00015538d },
            { 150000.0d, 0.00015559d },
            { 160000.0d, 0.000155888d },
            { 170000.0d, 0.000156288d },
            { 180000.0d, 0.000156808d },
            { 190000.0d, 0.000157464d },
            { 200000.0d, 0.000158275d },
            { 210000.0d, 0.00015926d },
            { 220000.0d, 0.000160437d },
            { 230000.0d, 0.000161827d },
            { 240000.0d, 0.000163451d },
            { 250000.0d, 0.00016533d },
            { 260000.0d, 0.000167486d },
            { 270000.0d, 0.000169778d },
            { 280000.0d, 0.00017205d },
            { 290000.0d, 0.000174302d },
            { 300000.0d, 0.000176533d },
            { 310000.0d, 0.000178744d },
            { 320000.0d, 0.000180935d },
            { 330000.0d, 0.000183106d },
            { 340000.0d, 0.000185257d },
            { 350000.0d, 0.000187388d },
            { 360000.0d, 0.000189499d },
            { 370000.0d, 0.00019159d },
            { 380000.0d, 0.000193663d },
            { 390000.0d, 0.000195717d },
            { 400000.0d, 0.000197753d },
            { 410000.0d, 0.000199771d },
            { 420000.0d, 0.000201772d },
            { 430000.0d, 0.000203756d },
            { 440000.0d, 0.000205723d },
            { 450000.0d, 0.000207676d },
            { 460000.0d, 0.000209613d },
            { 470000.0d, 0.000211536d },
            { 480000.0d, 0.000213445d },
            { 490000.0d, 0.000215335d },
            { 500000.0d, 0.000217208d },
            { 510000.0d, 0.000219063d },
            { 520000.0d, 0.000220901d },
            { 530000.0d, 0.000222723d },
            { 540000.0d, 0.000224528d },
            { 550000.0d, 0.000226318d },
            { 560000.0d, 0.000228094d },
            { 570000.0d, 0.000229855d },
            { 580000.0d, 0.000231603d },
            { 590000.0d, 0.000233339d },
            { 600000.0d, 0.000235063d },
            { 610000.0d, 0.000236776d },
            { 620000.0d, 0.000238478d },
            { 630000.0d, 0.000240172d },
            { 640000.0d, 0.000241856d },
            { 650000.0d, 0.00024353d },
            { 660000.0d, 0.000245195d },
            { 670000.0d, 0.000246852d },
            { 680000.0d, 0.000248502d },
            { 690000.0d, 0.000250146d },
            { 700000.0d, 0.000251783d },
            { 710000.0d, 0.000253415d },
            { 720000.0d, 0.000255044d },
            { 730000.0d, 0.000256668d },
            { 740000.0d, 0.000258289d },
            { 750000.0d, 0.000259909d },
            { 760000.0d, 0.000261527d },
            { 770000.0d, 0.000263143d },
            { 780000.0d, 0.000264755d },
            { 790000.0d, 0.000266358d },
            { 800000.0d, 0.000267948d },
            { 810000.0d, 0.000269526d },
            { 820000.0d, 0.000271093d },
            { 830000.0d, 0.000272648d },
            { 840000.0d, 0.00027419d },
            { 850000.0d, 0.000275717d },
            { 860000.0d, 0.000277229d },
            { 870000.0d, 0.000278725d },
            { 880000.0d, 0.000280208d },
            { 890000.0d, 0.000281675d },
            { 900000.0d, 0.000283129d },
            { 910000.0d, 0.000284568d },
            { 920000.0d, 0.000285993d },
            { 930000.0d, 0.000287402d },
            { 940000.0d, 0.000288794d },
            { 950000.0d, 0.000290171d },
            { 960000.0d, 0.000291532d },
            { 970000.0d, 0.000292876d },
            { 980000.0d, 0.000294205d },
            { 990000.0d, 0.000295519d },
            { 1000000.0d, 0.000296819d },
            { 1022000.0d, 0.000299626d },
            { 1044000.0d, 0.000302366d },
            { 1066000.0d, 0.000305037d },
            { 1088000.0d, 0.000307639d },
            { 1110000.0d, 0.000310155d },
            { 1132000.0d, 0.000312582d },
            { 1154000.0d, 0.000314904d },
            { 1176000.0d, 0.000317122d },
            { 1198000.0d, 0.000319233d },
            { 1220000.0d, 0.00032124d },
            { 1242000.0d, 0.000323144d },
            { 1264000.0d, 0.000324945d },
            { 1286000.0d, 0.000326644d },
            { 1308000.0d, 0.000328235d },
            { 1330000.0d, 0.00032972d },
            { 1352000.0d, 0.000331098d },
            { 1374000.0d, 0.000332371d },
            { 1396000.0d, 0.00033354d },
            { 1418000.0d, 0.000334606d },
            { 1440000.0d, 0.000335571d },
            { 1462000.0d, 0.000336436d },
            { 1484000.0d, 0.000337202d },
            { 1506000.0d, 0.000337872d },
            { 1528000.0d, 0.000338447d },
            { 1550000.0d, 0.000338928d },
            { 1572000.0d, 0.000339318d },
            { 1594000.0d, 0.000339612d },
            { 1616000.0d, 0.000339811d },
            { 1638000.0d, 0.000339917d },
            { 1660000.0d, 0.000339931d },
            { 1682000.0d, 0.000339854d },
            { 1704000.0d, 0.000339687d },
            { 1726000.0d, 0.000339431d },
            { 1748000.0d, 0.000339087d },
            { 1770000.0d, 0.000338659d },
            { 1792000.0d, 0.000338148d },
            { 1814000.0d, 0.000337557d },
            { 1836000.0d, 0.000336887d },
            { 1858000.0d, 0.000336142d },
            { 1880000.0d, 0.000335322d },
            { 1902000.0d, 0.000334421d },
            { 1924000.0d, 0.000333442d },
            { 1946000.0d, 0.000332385d },
            { 1968000.0d, 0.000331248d },
            { 1990000.0d, 0.000330031d },
            { 2012000.0d, 0.000328736d },
            { 2034000.0d, 0.000327366d },
            { 2056000.0d, 0.000325923d },
            { 2078000.0d, 0.00032441d },
            { 2100000.0d, 0.000322827d },
            { 2122000.0d, 0.00032118d },
            { 2144000.0d, 0.000319467d },
            { 2166000.0d, 0.000317694d },
            { 2188000.0d, 0.000315862d },
            { 2210000.0d, 0.000313973d },
            { 2232000.0d, 0.000312032d },
            { 2254000.0d, 0.000310038d },
            { 2276000.0d, 0.000307997d },
            { 2298000.0d, 0.000305909d },
            { 2320000.0d, 0.000303779d },
            { 2342000.0d, 0.000301609d },
            { 2364000.0d, 0.000299402d },
            { 2386000.0d, 0.00029716d },
            { 2408000.0d, 0.000294884d },
            { 2430000.0d, 0.000292579d },
            { 2452000.0d, 0.000290236d },
            { 2474000.0d, 0.000287851d },
            { 2496000.0d, 0.000285429d },
            { 2518000.0d, 0.000282971d },
            { 2540000.0d, 0.00028048d },
            { 2562000.0d, 0.000277958d },
            { 2584000.0d, 0.000275408d },
            { 2606000.0d, 0.000272833d },
            { 2628000.0d, 0.00027023d },
            { 2650000.0d, 0.000267569d },
            { 2672000.0d, 0.000264849d },
            { 2694000.0d, 0.000262074d },
            { 2716000.0d, 0.000259243d },
            { 2738000.0d, 0.000256359d },
            { 2760000.0d, 0.000253423d },
            { 2782000.0d, 0.000250436d },
            { 2804000.0d, 0.000247401d },
            { 2826000.0d, 0.00024432d },
            { 2848000.0d, 0.000241193d },
            { 2870000.0d, 0.000238023d },
            { 2892000.0d, 0.000234812d },
            { 2914000.0d, 0.000231562d },
            { 2936000.0d, 0.000228274d },
            { 2958000.0d, 0.00022495d },
            { 2980000.0d, 0.000221593d },
            { 3002000.0d, 0.000218204d },
            { 3024000.0d, 0.000214785d },
            { 3046000.0d, 0.000211337d },
            { 3068000.0d, 0.000207862d },
            { 3090000.0d, 0.000204361d },
            { 3112000.0d, 0.000200836d },
            { 3134000.0d, 0.000197291d },
            { 3156000.0d, 0.000193725d },
            { 3178000.0d, 0.000190143d },
            { 3200000.0d, 0.000186546d },
            { 3222000.0d, 0.000182935d },
            { 3244000.0d, 0.000179314d },
            { 3266000.0d, 0.000175685d },
            { 3288000.0d, 0.000172049d },
            { 3310000.0d, 0.00016841d },
            { 3332000.0d, 0.000164768d },
            { 3354000.0d, 0.000161128d },
            { 3376000.0d, 0.000157491d },
            { 3398000.0d, 0.000153859d },
            { 3420000.0d, 0.000150235d },
            { 3442000.0d, 0.000146622d },
            { 3464000.0d, 0.000143022d },
            { 3486000.0d, 0.000139437d },
            { 3508000.0d, 0.00013587d },
            { 3530000.0d, 0.000132324d },
            { 3552000.0d, 0.000128801d },
            { 3574000.0d, 0.000125304d },
            { 3596000.0d, 0.000121835d },
            { 3618000.0d, 0.000118398d },
            { 3640000.0d, 0.000114995d },
            { 3662000.0d, 0.000111629d },
            { 3684000.0d, 0.000108302d },
            { 3706000.0d, 0.000105018d },
            { 3728000.0d, 0.000101778d },
            { 3750000.0d, 0.0000985857d },
            { 3772000.0d, 0.0000954439d },
            { 3794000.0d, 0.0000923558d },
            { 3816000.0d, 0.0000893242d },
            { 3838000.0d, 0.0000863522d },
            { 3860000.0d, 0.0000834433d },
            { 3882000.0d, 0.0000806001d },
            { 3904000.0d, 0.0000778261d },
            { 3926000.0d, 0.000075124d },
            { 3948000.0d, 0.0000724967d },
            { 3970000.0d, 0.0000699476d },
            { 3992000.0d, 0.0000674797d },
            { 4014000.0d, 0.0000650965d },
            { 4036000.0d, 0.0000627957d },
            { 4058000.0d, 0.0000605731d },
            { 4080000.0d, 0.0000584307d },
            { 4102000.0d, 0.0000563716d },
            { 4124000.0d, 0.0000543995d },
            { 4146000.0d, 0.0000525173d },
            { 4168000.0d, 0.0000507285d },
            { 4190000.0d, 0.0000490365d },
            { 4212000.0d, 0.0000474446d },
            { 4234000.0d, 0.0000459561d },
            { 4256000.0d, 0.0000445711d },
            { 4278000.0d, 0.0000432397d },
            { 4300000.0d, 0.0000419441d },
            { 4322000.0d, 0.0000406861d },
            { 4344000.0d, 0.0000394619d },
            { 4366000.0d, 0.0000382647d },
            { 4388000.0d, 0.0000370957d },
            { 4410000.0d, 0.0000359558d },
            { 4432000.0d, 0.000034846d },
            { 4454000.0d, 0.0000337674d },
            { 4476000.0d, 0.0000327203d },
            { 4498000.0d, 0.0000316974d },
            { 4520000.0d, 0.0000306968d },
            { 4542000.0d, 0.0000297193d },
            { 4564000.0d, 0.0000287657d },
            { 4586000.0d, 0.0000278368d },
            { 4608000.0d, 0.0000269295d },
            { 4630000.0d, 0.0000260316d },
            { 4652000.0d, 0.0000251424d },
            { 4674000.0d, 0.0000242624d },
            { 4696000.0d, 0.0000233921d },
            { 4718000.0d, 0.0000225318d },
            { 4740000.0d, 0.000021682d },
            { 4762000.0d, 0.0000208434d },
            { 4784000.0d, 0.0000200163d },
            { 4806000.0d, 0.0000192013d },
            { 4828000.0d, 0.0000183988d },
            { 4850000.0d, 0.0000176093d },
            { 4872000.0d, 0.0000168333d },
            { 4894000.0d, 0.0000160714d },
            { 4916000.0d, 0.000015324d },
            { 4938000.0d, 0.0000145915d },
            { 4960000.0d, 0.0000138746d },
            { 4982000.0d, 0.0000131738d },
            { 5004000.0d, 0.0000124894d },
            { 5026000.0d, 0.0000118222d },
            { 5048000.0d, 0.0000111725d },
            { 5070000.0d, 0.0000105409d },
            { 5092000.0d, 0.00000992793d },
            { 5114000.0d, 0.00000933409d },
            { 5136000.0d, 0.00000875994d },
            { 5158000.0d, 0.00000820597d },
            { 5180000.0d, 0.00000767271d },
            { 5202000.0d, 0.00000716071d },
            { 5224000.0d, 0.0000066705d },
            { 5246000.0d, 0.00000620263d },
            { 5268000.0d, 0.00000575761d },
            { 5290000.0d, 0.00000533596d },
            { 5312000.0d, 0.00000493827d },
            { 5334000.0d, 0.00000456505d },
            { 5356000.0d, 0.00000421684d },
            { 5378000.0d, 0.00000389417d },
            { 5400000.0d, 0.00000359758d },
            { 5422000.0d, 0.00000332762d },
            { 5444000.0d, 0.00000308482d },
            { 5466000.0d, 0.00000286969d },
            { 5488000.0d, 0.00000268274d },
            { 5510000.0d, 0.0000025245d },
            { 5532000.0d, 0.00000239543d },
            { 5554000.0d, 0.00000229597d },
            { 5576000.0d, 0.00000222561d },
            { 5598000.0d, 0.0000021644d },
            { 5620000.0d, 0.00000210359d },
            { 5642000.0d, 0.00000204319d },
            { 5664000.0d, 0.00000198322d },
            { 5686000.0d, 0.00000192371d },
            { 5708000.0d, 0.00000186468d },
            { 5730000.0d, 0.00000180614d },
            { 5752000.0d, 0.00000174812d },
            { 5774000.0d, 0.00000169064d },
            { 5796000.0d, 0.00000163373d },
            { 5818000.0d, 0.0000015774d },
            { 5840000.0d, 0.00000152167d },
            { 5862000.0d, 0.00000146656d },
            { 5884000.0d, 0.0000014121d },
            { 5906000.0d, 0.00000135832d },
            { 5928000.0d, 0.00000130521d },
            { 5950000.0d, 0.00000125283d },
            { 5972000.0d, 0.00000120119d },
            { 5994000.0d, 0.00000115029d },
            { 6016000.0d, 0.00000110017d },
            { 6038000.0d, 0.00000105087d },
            { 6060000.0d, 0.00000100237d },
            { 6082000.0d, 0.000000954734d },
            { 6104000.0d, 0.000000907963d },
            { 6126000.0d, 0.000000862083d },
            { 6148000.0d, 0.000000817119d },
            { 6170000.0d, 0.000000773093d },
            { 6192000.0d, 0.000000730028d },
            { 6214000.0d, 0.000000687947d },
            { 6236000.0d, 0.000000646874d },
            { 6258000.0d, 0.000000606831d },
            { 6280000.0d, 0.000000567842d },
            { 6302000.0d, 0.000000529931d },
            { 6324000.0d, 0.00000049312d },
            { 6346000.0d, 0.000000457435d },
            { 6368000.0d, 0.000000422897d },
            { 6390000.0d, 0.000000389531d },
            { 6412000.0d, 0.000000357361d },
            { 6434000.0d, 0.00000032641d },
            { 6456000.0d, 0.000000296703d },
            { 6478000.0d, 0.000000268262d },
            { 6500000.0d, 0.000000241112d },
            { 6522000.0d, 0.000000215278d },
            { 6544000.0d, 0.000000190783d },
            { 6566000.0d, 0.000000167651d },
            { 6588000.0d, 0.000000145906d },
            { 6610000.0d, 0.000000125571d },
            { 6632000.0d, 0.000000106672d },
            { 6654000.0d, 0.0000000892315d },
            { 6676000.0d, 0.0000000732737d },
            { 6698000.0d, 0.0000000588221d },
            { 6720000.0d, 0.0000000459003d },
            { 6742000.0d, 0.0000000345318d },
            { 6764000.0d, 0.0000000247393d },
            { 6786000.0d, 0.0000000165456d },
            { 6808000.0d, 0.00000000997225d },
            { 6830000.0d, 0.00000000504024d },
            { 6852000.0d, 0.0000000017684d },
            { 6874000.0d, 0.00000000017087d },
            { 6884000.0d, 0d },

        }; 
    }
}
    