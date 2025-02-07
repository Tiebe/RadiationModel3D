using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium130n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium130n";
        public override double halfLife { get; } = 0.54d;
        public override double atomicWeight { get; } = 129.92537d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin130()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.19521999999999998d, new GammaParticle(89230.0, 0.01389)), new(0.07998d, new GammaParticle(129800.0, 0.00955)), new(0.0989d, new GammaParticle(137960.0, 0.00899)), new(0.003182d, new GammaParticle(219080.0, 0.00566)), new(0.01204d, new GammaParticle(261340.0, 0.00474)), new(0.01462d, new GammaParticle(278310.0, 0.00445)), new(0.07568d, new GammaParticle(408160.0, 0.00304)), new(0.0215d, new GammaParticle(411140.0, 0.00302)), new(0.01376d, new GammaParticle(492920.0, 0.00252)), new(0.01118d, new GammaParticle(496400.0, 0.0025)), new(0.0129d, new GammaParticle(602050.0, 0.00206)), new(0.4472d, new GammaParticle(774370.0, 0.0016)), new(0.0602d, new GammaParticle(807010.0, 0.00154)), new(0.0129d, new GammaParticle(980430.0, 0.00126)), new(0.86d, new GammaParticle(1221240.0, 0.00102)), new(0.0129d, new GammaParticle(1269600.0, 0.00098)), new(0.03956d, new GammaParticle(1340190.0, 0.00093)), new(0.0215d, new GammaParticle(1429220.0, 0.00087)), new(0.01118d, new GammaParticle(1775490.0, 0.0007)), new(0.1247d, new GammaParticle(2028340.0, 0.00061)), new(0.0215d, new GammaParticle(2203850.0, 0.00056)), new(0.03956d, new GammaParticle(2320720.0, 0.00053)), new(0.15222d, new GammaParticle(2377140.0, 0.00052)), new(0.01118d, new GammaParticle(2388500.0, 0.00052)), new(0.02236d, new GammaParticle(2409920.0, 0.00051)), new(0.01118d, new GammaParticle(2468100.0, 0.0005)), new(0.01118d, new GammaParticle(2759000.0, 0.00045)), new(0.00946d, new GammaParticle(3003600.0, 0.00041)), new(0.0051600000000000005d, new GammaParticle(3178200.0, 0.00039)), new(0.09115999999999999d, new GammaParticle(3184000.0, 0.00039)), new(0.043d, new GammaParticle(3241700.0, 0.00038)), new(0.03354d, new GammaParticle(4041500.0, 0.00031)), new(0.0079259496128d, new GammaParticle(3753.0, 0.33036)), new(0.023723602393844512d, new GammaParticle(25044.0, 0.04951)), new(0.044401277173581354d, new GammaParticle(25271.0, 0.04906)), new(0.012555011221866454d, new GammaParticle(28579.0, 0.04338)), new(0.015028348432574145d, new GammaParticle(28810.0, 0.04304)), new(0.0024733372107076917d, new GammaParticle(29107.0, 0.0426)) } },
            { 0.0165d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin130()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.19521999999999998d, new GammaParticle(89230.0, 0.01389)), new(0.07998d, new GammaParticle(129800.0, 0.00955)), new(0.0989d, new GammaParticle(137960.0, 0.00899)), new(0.003182d, new GammaParticle(219080.0, 0.00566)), new(0.01204d, new GammaParticle(261340.0, 0.00474)), new(0.01462d, new GammaParticle(278310.0, 0.00445)), new(0.07568d, new GammaParticle(408160.0, 0.00304)), new(0.0215d, new GammaParticle(411140.0, 0.00302)), new(0.01376d, new GammaParticle(492920.0, 0.00252)), new(0.01118d, new GammaParticle(496400.0, 0.0025)), new(0.0129d, new GammaParticle(602050.0, 0.00206)), new(0.4472d, new GammaParticle(774370.0, 0.0016)), new(0.0602d, new GammaParticle(807010.0, 0.00154)), new(0.0129d, new GammaParticle(980430.0, 0.00126)), new(0.86d, new GammaParticle(1221240.0, 0.00102)), new(0.0129d, new GammaParticle(1269600.0, 0.00098)), new(0.03956d, new GammaParticle(1340190.0, 0.00093)), new(0.0215d, new GammaParticle(1429220.0, 0.00087)), new(0.01118d, new GammaParticle(1775490.0, 0.0007)), new(0.1247d, new GammaParticle(2028340.0, 0.00061)), new(0.0215d, new GammaParticle(2203850.0, 0.00056)), new(0.03956d, new GammaParticle(2320720.0, 0.00053)), new(0.15222d, new GammaParticle(2377140.0, 0.00052)), new(0.01118d, new GammaParticle(2388500.0, 0.00052)), new(0.02236d, new GammaParticle(2409920.0, 0.00051)), new(0.01118d, new GammaParticle(2468100.0, 0.0005)), new(0.01118d, new GammaParticle(2759000.0, 0.00045)), new(0.00946d, new GammaParticle(3003600.0, 0.00041)), new(0.0051600000000000005d, new GammaParticle(3178200.0, 0.00039)), new(0.09115999999999999d, new GammaParticle(3184000.0, 0.00039)), new(0.043d, new GammaParticle(3241700.0, 0.00038)), new(0.03354d, new GammaParticle(4041500.0, 0.00031)), new(0.0079259496128d, new GammaParticle(3753.0, 0.33036)), new(0.023723602393844512d, new GammaParticle(25044.0, 0.04951)), new(0.044401277173581354d, new GammaParticle(25271.0, 0.04906)), new(0.012555011221866454d, new GammaParticle(28579.0, 0.04338)), new(0.015028348432574145d, new GammaParticle(28810.0, 0.04304)), new(0.0024733372107076917d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000293122d },
            { 20000.0d, 0.0000310744d },
            { 40000.0d, 0.0000329267d },
            { 60000.0d, 0.0000348694d },
            { 80000.0d, 0.0000369042d },
            { 100000.0d, 0.0000390162d },
            { 120000.0d, 0.0000411925d },
            { 140000.0d, 0.0000434236d },
            { 160000.0d, 0.0000457026d },
            { 180000.0d, 0.0000480241d },
            { 200000.0d, 0.0000503843d },
            { 220000.0d, 0.0000527797d },
            { 240000.0d, 0.0000552076d },
            { 260000.0d, 0.0000576656d },
            { 280000.0d, 0.0000601514d },
            { 300000.0d, 0.0000626634d },
            { 320000.0d, 0.0000651995d },
            { 340000.0d, 0.0000677581d },
            { 360000.0d, 0.0000703377d },
            { 380000.0d, 0.0000729368d },
            { 400000.0d, 0.000075554d },
            { 420000.0d, 0.0000781877d },
            { 440000.0d, 0.0000808369d },
            { 460000.0d, 0.0000835d },
            { 480000.0d, 0.0000861759d },
            { 500000.0d, 0.0000888633d },
            { 520000.0d, 0.0000915611d },
            { 540000.0d, 0.0000942681d },
            { 560000.0d, 0.000096983d },
            { 580000.0d, 0.0000997048d },
            { 600000.0d, 0.000102432d },
            { 620000.0d, 0.000105165d },
            { 640000.0d, 0.000107901d },
            { 660000.0d, 0.00011064d },
            { 680000.0d, 0.00011338d },
            { 700000.0d, 0.000116121d },
            { 720000.0d, 0.000118861d },
            { 740000.0d, 0.000121599d },
            { 760000.0d, 0.000124336d },
            { 780000.0d, 0.00012707d },
            { 800000.0d, 0.000129799d },
            { 820000.0d, 0.000132524d },
            { 840000.0d, 0.000135242d },
            { 860000.0d, 0.000137953d },
            { 880000.0d, 0.000140657d },
            { 900000.0d, 0.000143352d },
            { 920000.0d, 0.000146038d },
            { 940000.0d, 0.000148714d },
            { 960000.0d, 0.000151378d },
            { 980000.0d, 0.000154031d },
            { 1000000.0d, 0.000156671d },
            { 1026000.0d, 0.000160083d },
            { 1052000.0d, 0.000163471d },
            { 1078000.0d, 0.000166834d },
            { 1104000.0d, 0.000170169d },
            { 1130000.0d, 0.000173475d },
            { 1156000.0d, 0.000176751d },
            { 1182000.0d, 0.000179996d },
            { 1208000.0d, 0.000183207d },
            { 1234000.0d, 0.000186383d },
            { 1260000.0d, 0.000189524d },
            { 1286000.0d, 0.000192628d },
            { 1312000.0d, 0.000195693d },
            { 1338000.0d, 0.000198717d },
            { 1364000.0d, 0.000201702d },
            { 1390000.0d, 0.000204643d },
            { 1416000.0d, 0.000207542d },
            { 1442000.0d, 0.000210396d },
            { 1468000.0d, 0.000213205d },
            { 1494000.0d, 0.000215967d },
            { 1520000.0d, 0.000218681d },
            { 1546000.0d, 0.000221347d },
            { 1572000.0d, 0.000223963d },
            { 1598000.0d, 0.000226529d },
            { 1624000.0d, 0.000229044d },
            { 1650000.0d, 0.000231506d },
            { 1676000.0d, 0.000233915d },
            { 1702000.0d, 0.000236269d },
            { 1728000.0d, 0.000238569d },
            { 1754000.0d, 0.000240814d },
            { 1780000.0d, 0.000243003d },
            { 1806000.0d, 0.000245134d },
            { 1832000.0d, 0.000247208d },
            { 1858000.0d, 0.000249223d },
            { 1884000.0d, 0.00025118d },
            { 1910000.0d, 0.000253077d },
            { 1936000.0d, 0.000254914d },
            { 1962000.0d, 0.000256691d },
            { 1988000.0d, 0.000258406d },
            { 2014000.0d, 0.00026006d },
            { 2040000.0d, 0.000261651d },
            { 2066000.0d, 0.000263181d },
            { 2092000.0d, 0.000264646d },
            { 2118000.0d, 0.000266049d },
            { 2144000.0d, 0.000267389d },
            { 2170000.0d, 0.000268663d },
            { 2196000.0d, 0.000269874d },
            { 2222000.0d, 0.000271021d },
            { 2248000.0d, 0.000272103d },
            { 2274000.0d, 0.000273119d },
            { 2300000.0d, 0.000274069d },
            { 2326000.0d, 0.000274955d },
            { 2352000.0d, 0.000275775d },
            { 2378000.0d, 0.000276529d },
            { 2404000.0d, 0.000277216d },
            { 2430000.0d, 0.000277839d },
            { 2456000.0d, 0.000278395d },
            { 2482000.0d, 0.000278885d },
            { 2508000.0d, 0.000279309d },
            { 2534000.0d, 0.000279666d },
            { 2560000.0d, 0.000279958d },
            { 2586000.0d, 0.000280183d },
            { 2612000.0d, 0.000280343d },
            { 2638000.0d, 0.000280436d },
            { 2664000.0d, 0.000280463d },
            { 2690000.0d, 0.000280426d },
            { 2716000.0d, 0.000280322d },
            { 2742000.0d, 0.000280154d },
            { 2768000.0d, 0.00027992d },
            { 2794000.0d, 0.000279621d },
            { 2820000.0d, 0.000279258d },
            { 2846000.0d, 0.00027883d },
            { 2872000.0d, 0.000278339d },
            { 2898000.0d, 0.000277783d },
            { 2924000.0d, 0.000277163d },
            { 2950000.0d, 0.000276481d },
            { 2976000.0d, 0.000275737d },
            { 3002000.0d, 0.000274929d },
            { 3028000.0d, 0.000274061d },
            { 3054000.0d, 0.00027313d },
            { 3080000.0d, 0.000272139d },
            { 3106000.0d, 0.000271087d },
            { 3132000.0d, 0.000269975d },
            { 3158000.0d, 0.000268803d },
            { 3184000.0d, 0.000267573d },
            { 3210000.0d, 0.000266284d },
            { 3236000.0d, 0.000264937d },
            { 3262000.0d, 0.000263534d },
            { 3288000.0d, 0.000262073d },
            { 3314000.0d, 0.000260556d },
            { 3340000.0d, 0.000258984d },
            { 3366000.0d, 0.000257358d },
            { 3392000.0d, 0.000255677d },
            { 3418000.0d, 0.000253943d },
            { 3444000.0d, 0.000252157d },
            { 3470000.0d, 0.000250319d },
            { 3496000.0d, 0.000248431d },
            { 3522000.0d, 0.000246491d },
            { 3548000.0d, 0.000244502d },
            { 3574000.0d, 0.000242465d },
            { 3600000.0d, 0.00024038d },
            { 3626000.0d, 0.000238249d },
            { 3652000.0d, 0.000236071d },
            { 3678000.0d, 0.000233849d },
            { 3704000.0d, 0.000231581d },
            { 3730000.0d, 0.000229271d },
            { 3756000.0d, 0.000226919d },
            { 3782000.0d, 0.000224525d },
            { 3808000.0d, 0.000222091d },
            { 3834000.0d, 0.000219618d },
            { 3860000.0d, 0.000217106d },
            { 3886000.0d, 0.000214558d },
            { 3912000.0d, 0.000211972d },
            { 3938000.0d, 0.000209352d },
            { 3964000.0d, 0.000206699d },
            { 3990000.0d, 0.000204012d },
            { 4016000.0d, 0.000201293d },
            { 4042000.0d, 0.000198544d },
            { 4068000.0d, 0.000195765d },
            { 4094000.0d, 0.000192958d },
            { 4120000.0d, 0.000190125d },
            { 4146000.0d, 0.000187265d },
            { 4172000.0d, 0.00018438d },
            { 4198000.0d, 0.000181473d },
            { 4224000.0d, 0.000178543d },
            { 4250000.0d, 0.000175593d },
            { 4276000.0d, 0.000172623d },
            { 4302000.0d, 0.000169634d },
            { 4328000.0d, 0.00016663d },
            { 4354000.0d, 0.000163608d },
            { 4380000.0d, 0.000160574d },
            { 4406000.0d, 0.000157526d },
            { 4432000.0d, 0.000154467d },
            { 4458000.0d, 0.000151399d },
            { 4484000.0d, 0.000148321d },
            { 4510000.0d, 0.000145236d },
            { 4536000.0d, 0.000142146d },
            { 4562000.0d, 0.000139051d },
            { 4588000.0d, 0.000135954d },
            { 4614000.0d, 0.000132856d },
            { 4640000.0d, 0.000129758d },
            { 4666000.0d, 0.000126662d },
            { 4692000.0d, 0.00012357d },
            { 4718000.0d, 0.000120482d },
            { 4744000.0d, 0.000117401d },
            { 4770000.0d, 0.000114328d },
            { 4796000.0d, 0.000111264d },
            { 4822000.0d, 0.000108213d },
            { 4848000.0d, 0.000105174d },
            { 4874000.0d, 0.00010215d },
            { 4900000.0d, 0.0000991417d },
            { 4926000.0d, 0.0000961519d },
            { 4952000.0d, 0.0000931818d },
            { 4978000.0d, 0.0000902332d },
            { 5004000.0d, 0.0000873076d },
            { 5030000.0d, 0.000084407d },
            { 5056000.0d, 0.000081533d },
            { 5082000.0d, 0.0000786872d },
            { 5108000.0d, 0.0000758718d },
            { 5134000.0d, 0.0000730883d },
            { 5160000.0d, 0.0000703386d },
            { 5186000.0d, 0.0000676245d },
            { 5212000.0d, 0.0000649478d },
            { 5238000.0d, 0.0000623103d },
            { 5264000.0d, 0.0000597139d },
            { 5290000.0d, 0.0000571605d },
            { 5316000.0d, 0.0000546521d },
            { 5342000.0d, 0.0000521903d },
            { 5368000.0d, 0.0000497773d },
            { 5394000.0d, 0.0000474149d },
            { 5420000.0d, 0.000045105d },
            { 5446000.0d, 0.0000428496d },
            { 5472000.0d, 0.0000406505d },
            { 5498000.0d, 0.00003851d },
            { 5524000.0d, 0.0000364296d },
            { 5550000.0d, 0.0000344118d },
            { 5576000.0d, 0.0000324582d },
            { 5602000.0d, 0.000030571d },
            { 5628000.0d, 0.0000287522d },
            { 5654000.0d, 0.0000270037d },
            { 5680000.0d, 0.0000253277d },
            { 5706000.0d, 0.0000237261d },
            { 5732000.0d, 0.0000222012d },
            { 5758000.0d, 0.0000207547d },
            { 5784000.0d, 0.0000193889d },
            { 5810000.0d, 0.0000181059d },
            { 5836000.0d, 0.0000169076d },
            { 5862000.0d, 0.0000157961d },
            { 5888000.0d, 0.0000147735d },
            { 5914000.0d, 0.0000138419d },
            { 5940000.0d, 0.0000130033d },
            { 5966000.0d, 0.0000122598d },
            { 5992000.0d, 0.0000116134d },
            { 6018000.0d, 0.0000110659d },
            { 6044000.0d, 0.0000106193d },
            { 6070000.0d, 0.0000102753d },
            { 6096000.0d, 0.0000100321d },
            { 6122000.0d, 0.00000981962d },
            { 6148000.0d, 0.00000960725d },
            { 6174000.0d, 0.0000093951d },
            { 6200000.0d, 0.00000918323d },
            { 6226000.0d, 0.00000897171d },
            { 6252000.0d, 0.00000876059d },
            { 6278000.0d, 0.00000854997d },
            { 6304000.0d, 0.00000833991d },
            { 6330000.0d, 0.00000813049d },
            { 6356000.0d, 0.00000792176d },
            { 6382000.0d, 0.00000771379d },
            { 6408000.0d, 0.00000750668d },
            { 6434000.0d, 0.00000730049d },
            { 6460000.0d, 0.0000070953d },
            { 6486000.0d, 0.00000689118d },
            { 6512000.0d, 0.00000668821d },
            { 6538000.0d, 0.00000648647d },
            { 6564000.0d, 0.00000628605d },
            { 6590000.0d, 0.00000608702d },
            { 6616000.0d, 0.00000588945d },
            { 6642000.0d, 0.00000569344d },
            { 6668000.0d, 0.00000549908d },
            { 6694000.0d, 0.00000530643d },
            { 6720000.0d, 0.00000511559d },
            { 6746000.0d, 0.00000492664d },
            { 6772000.0d, 0.00000473968d },
            { 6798000.0d, 0.0000045548d },
            { 6824000.0d, 0.00000437208d },
            { 6850000.0d, 0.00000419161d },
            { 6876000.0d, 0.0000040135d },
            { 6902000.0d, 0.00000383782d },
            { 6928000.0d, 0.00000366467d },
            { 6954000.0d, 0.00000349415d },
            { 6980000.0d, 0.00000332637d },
            { 7006000.0d, 0.0000031614d },
            { 7032000.0d, 0.00000299936d },
            { 7058000.0d, 0.00000284036d },
            { 7084000.0d, 0.00000268447d },
            { 7110000.0d, 0.00000253181d },
            { 7136000.0d, 0.00000238249d },
            { 7162000.0d, 0.00000223661d },
            { 7188000.0d, 0.00000209426d },
            { 7214000.0d, 0.00000195558d },
            { 7240000.0d, 0.00000182065d },
            { 7266000.0d, 0.00000168959d },
            { 7292000.0d, 0.00000156251d },
            { 7318000.0d, 0.00000143953d },
            { 7344000.0d, 0.00000132075d },
            { 7370000.0d, 0.0000012063d },
            { 7396000.0d, 0.00000109628d },
            { 7422000.0d, 0.000000990821d },
            { 7448000.0d, 0.000000890032d },
            { 7474000.0d, 0.000000794035d },
            { 7500000.0d, 0.000000702951d },
            { 7526000.0d, 0.0000006169d },
            { 7552000.0d, 0.000000536007d },
            { 7578000.0d, 0.000000460393d },
            { 7604000.0d, 0.000000390182d },
            { 7630000.0d, 0.000000325501d },
            { 7656000.0d, 0.000000266474d },
            { 7682000.0d, 0.000000213229d },
            { 7708000.0d, 0.000000165891d },
            { 7734000.0d, 0.000000124586d },
            { 7760000.0d, 0.0000000894407d },
            { 7786000.0d, 0.0000000605775d },
            { 7812000.0d, 0.0000000381166d },
            { 7838000.0d, 0.0000000221689d },
            { 7864000.0d, 0.0000000127601d },
            { 7890000.0d, 0.00000000684028d },
            { 7916000.0d, 0.00000000272102d },
            { 7942000.0d, 0.000000000457619d },
            { 7960000.0d, 0d },

        }; 
    }
}
    