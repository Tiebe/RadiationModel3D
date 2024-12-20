using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Helium8 : RadioactiveSubstance
    {
        public override string name { get; } = "Helium8";
        public override double halfLife { get; } = 0.1191d;
        public override double atomicWeight { get; } = 8.03393d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lithium8()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.84d, new GammaParticle(980000.0, 0.00127)) } },
            { 0.16d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lithium8()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.84d, new GammaParticle(980000.0, 0.00127)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.00000487533d },
            { 3000.0d, 0.00000592139d },
            { 6000.0d, 0.00000683734d },
            { 9000.0d, 0.00000762319d },
            { 12000.0d, 0.00000833444d },
            { 15000.0d, 0.00000899502d },
            { 18000.0d, 0.00000961773d },
            { 21000.0d, 0.0000102104d },
            { 24000.0d, 0.0000107782d },
            { 27000.0d, 0.0000113247d },
            { 30000.0d, 0.0000118525d },
            { 33000.0d, 0.0000123638d },
            { 36000.0d, 0.00001286d },
            { 39000.0d, 0.0000133423d },
            { 42000.0d, 0.0000138119d },
            { 45000.0d, 0.0000142694d },
            { 48000.0d, 0.0000147157d },
            { 51000.0d, 0.0000151513d },
            { 54000.0d, 0.0000155766d },
            { 57000.0d, 0.0000159972d },
            { 60000.0d, 0.0000164099d },
            { 63000.0d, 0.0000168149d },
            { 66000.0d, 0.0000172125d },
            { 69000.0d, 0.000017603d },
            { 72000.0d, 0.0000179867d },
            { 75000.0d, 0.0000183655d },
            { 78000.0d, 0.0000187401d },
            { 81000.0d, 0.0000191092d },
            { 84000.0d, 0.0000194731d },
            { 87000.0d, 0.0000198317d },
            { 90000.0d, 0.0000201853d },
            { 93000.0d, 0.000020535d },
            { 96000.0d, 0.00002088d },
            { 99000.0d, 0.0000212246d },
            { 102000.0d, 0.0000215658d },
            { 112000.0d, 0.0000226798d },
            { 122000.0d, 0.0000237594d },
            { 132000.0d, 0.0000248096d },
            { 142000.0d, 0.0000258351d },
            { 152000.0d, 0.0000268356d },
            { 162000.0d, 0.0000278128d },
            { 172000.0d, 0.0000287702d },
            { 182000.0d, 0.0000297072d },
            { 192000.0d, 0.0000306247d },
            { 202000.0d, 0.0000315245d },
            { 212000.0d, 0.000032407d },
            { 222000.0d, 0.0000332722d },
            { 232000.0d, 0.0000341215d },
            { 242000.0d, 0.000034955d },
            { 252000.0d, 0.0000357729d },
            { 262000.0d, 0.000036576d },
            { 272000.0d, 0.0000373645d },
            { 282000.0d, 0.0000381387d },
            { 292000.0d, 0.0000388988d },
            { 302000.0d, 0.0000396454d },
            { 312000.0d, 0.0000403785d },
            { 322000.0d, 0.0000410983d },
            { 332000.0d, 0.0000418054d },
            { 342000.0d, 0.0000425d },
            { 352000.0d, 0.0000431821d },
            { 362000.0d, 0.0000438521d },
            { 372000.0d, 0.0000445103d },
            { 382000.0d, 0.000045157d },
            { 392000.0d, 0.0000457923d },
            { 402000.0d, 0.0000464167d },
            { 412000.0d, 0.0000470304d },
            { 422000.0d, 0.0000476337d },
            { 432000.0d, 0.0000482268d },
            { 442000.0d, 0.0000488101d },
            { 452000.0d, 0.0000493839d },
            { 462000.0d, 0.0000499485d },
            { 472000.0d, 0.0000505043d },
            { 482000.0d, 0.0000510515d },
            { 492000.0d, 0.0000515907d },
            { 502000.0d, 0.0000521221d },
            { 512000.0d, 0.000052646d },
            { 522000.0d, 0.0000531629d },
            { 532000.0d, 0.0000536734d },
            { 542000.0d, 0.0000541777d },
            { 552000.0d, 0.0000546762d },
            { 562000.0d, 0.0000551694d },
            { 572000.0d, 0.0000556578d },
            { 582000.0d, 0.0000561418d },
            { 592000.0d, 0.000056622d },
            { 602000.0d, 0.0000570987d },
            { 612000.0d, 0.0000575727d },
            { 622000.0d, 0.0000580443d },
            { 632000.0d, 0.0000585141d },
            { 642000.0d, 0.0000589826d },
            { 652000.0d, 0.0000594503d },
            { 662000.0d, 0.000059918d },
            { 672000.0d, 0.0000603862d },
            { 682000.0d, 0.0000608553d },
            { 692000.0d, 0.0000613262d },
            { 702000.0d, 0.0000617995d },
            { 712000.0d, 0.0000622757d },
            { 722000.0d, 0.0000627556d },
            { 732000.0d, 0.0000632398d },
            { 742000.0d, 0.000063729d },
            { 752000.0d, 0.0000642239d },
            { 762000.0d, 0.0000647252d },
            { 772000.0d, 0.0000652337d },
            { 782000.0d, 0.00006575d },
            { 792000.0d, 0.000066275d },
            { 802000.0d, 0.0000668094d },
            { 812000.0d, 0.000067354d },
            { 822000.0d, 0.0000679097d },
            { 832000.0d, 0.0000684773d },
            { 842000.0d, 0.0000690573d },
            { 852000.0d, 0.0000696509d },
            { 862000.0d, 0.0000702589d },
            { 872000.0d, 0.0000708821d },
            { 882000.0d, 0.0000715214d },
            { 892000.0d, 0.0000721777d },
            { 902000.0d, 0.000072852d },
            { 912000.0d, 0.000073545d },
            { 922000.0d, 0.0000742578d },
            { 932000.0d, 0.0000749913d },
            { 942000.0d, 0.0000757464d },
            { 952000.0d, 0.0000765242d },
            { 962000.0d, 0.0000773255d },
            { 972000.0d, 0.0000781513d },
            { 982000.0d, 0.0000790025d },
            { 992000.0d, 0.0000798646d },
            { 1002000.0d, 0.0000807273d },
            { 1034000.0d, 0.0000834912d },
            { 1066000.0d, 0.0000862587d },
            { 1098000.0d, 0.0000890286d },
            { 1130000.0d, 0.0000917987d },
            { 1162000.0d, 0.000094568d },
            { 1194000.0d, 0.0000973345d },
            { 1226000.0d, 0.000100097d },
            { 1258000.0d, 0.000102854d },
            { 1290000.0d, 0.000105604d },
            { 1322000.0d, 0.000108345d },
            { 1354000.0d, 0.000111077d },
            { 1386000.0d, 0.000113797d },
            { 1418000.0d, 0.000116504d },
            { 1450000.0d, 0.000119197d },
            { 1482000.0d, 0.000121875d },
            { 1514000.0d, 0.000124536d },
            { 1546000.0d, 0.000127179d },
            { 1578000.0d, 0.000129803d },
            { 1610000.0d, 0.000132407d },
            { 1642000.0d, 0.000134989d },
            { 1674000.0d, 0.000137548d },
            { 1706000.0d, 0.000140083d },
            { 1738000.0d, 0.000142594d },
            { 1770000.0d, 0.000145078d },
            { 1802000.0d, 0.000147535d },
            { 1834000.0d, 0.000149963d },
            { 1866000.0d, 0.000152362d },
            { 1898000.0d, 0.000154731d },
            { 1930000.0d, 0.000157069d },
            { 1962000.0d, 0.000159375d },
            { 1994000.0d, 0.000161647d },
            { 2026000.0d, 0.000163886d },
            { 2058000.0d, 0.00016609d },
            { 2090000.0d, 0.000168258d },
            { 2122000.0d, 0.000170389d },
            { 2154000.0d, 0.000172484d },
            { 2186000.0d, 0.00017454d },
            { 2218000.0d, 0.000176558d },
            { 2250000.0d, 0.000178536d },
            { 2282000.0d, 0.000180474d },
            { 2314000.0d, 0.000182371d },
            { 2346000.0d, 0.000184227d },
            { 2378000.0d, 0.00018604d },
            { 2410000.0d, 0.000187812d },
            { 2442000.0d, 0.00018954d },
            { 2474000.0d, 0.000191224d },
            { 2506000.0d, 0.000192864d },
            { 2538000.0d, 0.00019446d },
            { 2570000.0d, 0.000196011d },
            { 2602000.0d, 0.000197516d },
            { 2634000.0d, 0.000198975d },
            { 2666000.0d, 0.000200387d },
            { 2698000.0d, 0.000201754d },
            { 2730000.0d, 0.000203073d },
            { 2762000.0d, 0.000204345d },
            { 2794000.0d, 0.00020557d },
            { 2826000.0d, 0.000206746d },
            { 2858000.0d, 0.000207875d },
            { 2890000.0d, 0.000208956d },
            { 2922000.0d, 0.000209988d },
            { 2954000.0d, 0.000210972d },
            { 2986000.0d, 0.000211907d },
            { 3018000.0d, 0.000212794d },
            { 3050000.0d, 0.000213632d },
            { 3082000.0d, 0.000214421d },
            { 3114000.0d, 0.000215162d },
            { 3146000.0d, 0.000215853d },
            { 3178000.0d, 0.000216496d },
            { 3210000.0d, 0.00021709d },
            { 3242000.0d, 0.000217636d },
            { 3274000.0d, 0.000218132d },
            { 3306000.0d, 0.000218581d },
            { 3338000.0d, 0.000218982d },
            { 3370000.0d, 0.000219334d },
            { 3402000.0d, 0.000219639d },
            { 3434000.0d, 0.000219897d },
            { 3466000.0d, 0.000220106d },
            { 3498000.0d, 0.000220269d },
            { 3530000.0d, 0.000220385d },
            { 3562000.0d, 0.000220455d },
            { 3594000.0d, 0.000220479d },
            { 3626000.0d, 0.000220458d },
            { 3658000.0d, 0.000220391d },
            { 3690000.0d, 0.00022028d },
            { 3722000.0d, 0.000220124d },
            { 3754000.0d, 0.000219924d },
            { 3786000.0d, 0.000219681d },
            { 3818000.0d, 0.000219395d },
            { 3850000.0d, 0.000219068d },
            { 3882000.0d, 0.000218698d },
            { 3914000.0d, 0.000218288d },
            { 3946000.0d, 0.000217837d },
            { 3978000.0d, 0.000217347d },
            { 4010000.0d, 0.000216817d },
            { 4042000.0d, 0.000216249d },
            { 4074000.0d, 0.000215644d },
            { 4106000.0d, 0.000215001d },
            { 4138000.0d, 0.000214324d },
            { 4170000.0d, 0.00021361d },
            { 4202000.0d, 0.000212862d },
            { 4234000.0d, 0.000212082d },
            { 4266000.0d, 0.000211268d },
            { 4298000.0d, 0.000210422d },
            { 4330000.0d, 0.000209546d },
            { 4362000.0d, 0.000208639d },
            { 4394000.0d, 0.000207705d },
            { 4426000.0d, 0.000206741d },
            { 4458000.0d, 0.000205752d },
            { 4490000.0d, 0.000204735d },
            { 4522000.0d, 0.000203695d },
            { 4554000.0d, 0.000202632d },
            { 4586000.0d, 0.000201545d },
            { 4618000.0d, 0.000200437d },
            { 4650000.0d, 0.000199308d },
            { 4682000.0d, 0.000198162d },
            { 4714000.0d, 0.000196996d },
            { 4746000.0d, 0.000195815d },
            { 4778000.0d, 0.000194618d },
            { 4810000.0d, 0.000193407d },
            { 4842000.0d, 0.000192184d },
            { 4874000.0d, 0.000190948d },
            { 4906000.0d, 0.000189703d },
            { 4938000.0d, 0.00018845d },
            { 4970000.0d, 0.000187189d },
            { 5002000.0d, 0.000185922d },
            { 5034000.0d, 0.000184651d },
            { 5066000.0d, 0.000183377d },
            { 5098000.0d, 0.000182101d },
            { 5130000.0d, 0.000180825d },
            { 5162000.0d, 0.000179552d },
            { 5194000.0d, 0.000178281d },
            { 5226000.0d, 0.000177015d },
            { 5258000.0d, 0.000175755d },
            { 5290000.0d, 0.000174503d },
            { 5322000.0d, 0.000173259d },
            { 5354000.0d, 0.000172028d },
            { 5386000.0d, 0.000170809d },
            { 5418000.0d, 0.000169604d },
            { 5450000.0d, 0.000168415d },
            { 5482000.0d, 0.000167243d },
            { 5514000.0d, 0.000166087d },
            { 5546000.0d, 0.000164913d },
            { 5578000.0d, 0.000163716d },
            { 5610000.0d, 0.000162495d },
            { 5642000.0d, 0.000161252d },
            { 5674000.0d, 0.000159985d },
            { 5706000.0d, 0.000158697d },
            { 5738000.0d, 0.000157386d },
            { 5770000.0d, 0.000156055d },
            { 5802000.0d, 0.000154703d },
            { 5834000.0d, 0.000153331d },
            { 5866000.0d, 0.000151938d },
            { 5898000.0d, 0.000150527d },
            { 5930000.0d, 0.000149096d },
            { 5962000.0d, 0.000147647d },
            { 5994000.0d, 0.000146181d },
            { 6026000.0d, 0.000144697d },
            { 6058000.0d, 0.000143197d },
            { 6090000.0d, 0.00014168d },
            { 6122000.0d, 0.000140148d },
            { 6154000.0d, 0.000138601d },
            { 6186000.0d, 0.00013704d },
            { 6218000.0d, 0.000135464d },
            { 6250000.0d, 0.000133876d },
            { 6282000.0d, 0.000132275d },
            { 6314000.0d, 0.000130661d },
            { 6346000.0d, 0.000129037d },
            { 6378000.0d, 0.000127402d },
            { 6410000.0d, 0.000125756d },
            { 6442000.0d, 0.000124101d },
            { 6474000.0d, 0.000122438d },
            { 6506000.0d, 0.000120767d },
            { 6538000.0d, 0.000119087d },
            { 6570000.0d, 0.000117402d },
            { 6602000.0d, 0.00011571d },
            { 6634000.0d, 0.000114012d },
            { 6666000.0d, 0.00011231d },
            { 6698000.0d, 0.000110604d },
            { 6730000.0d, 0.000108895d },
            { 6762000.0d, 0.000107184d },
            { 6794000.0d, 0.00010547d },
            { 6826000.0d, 0.000103756d },
            { 6858000.0d, 0.000102042d },
            { 6890000.0d, 0.000100328d },
            { 6922000.0d, 0.0000986151d },
            { 6954000.0d, 0.0000969046d },
            { 6986000.0d, 0.0000951972d },
            { 7018000.0d, 0.0000934934d },
            { 7050000.0d, 0.0000917941d },
            { 7082000.0d, 0.0000901003d },
            { 7114000.0d, 0.0000884125d },
            { 7146000.0d, 0.0000867318d },
            { 7178000.0d, 0.000085059d },
            { 7210000.0d, 0.0000833948d },
            { 7242000.0d, 0.0000817403d },
            { 7274000.0d, 0.0000800961d },
            { 7306000.0d, 0.0000784631d },
            { 7338000.0d, 0.0000768424d },
            { 7370000.0d, 0.0000752347d },
            { 7402000.0d, 0.000073641d },
            { 7434000.0d, 0.000072062d },
            { 7466000.0d, 0.0000704986d },
            { 7498000.0d, 0.0000689519d },
            { 7530000.0d, 0.0000674225d },
            { 7562000.0d, 0.0000659114d },
            { 7594000.0d, 0.0000644147d },
            { 7626000.0d, 0.0000629204d },
            { 7658000.0d, 0.0000614287d },
            { 7690000.0d, 0.00005994d },
            { 7722000.0d, 0.0000584548d },
            { 7754000.0d, 0.0000569738d },
            { 7786000.0d, 0.0000554975d },
            { 7818000.0d, 0.0000540264d },
            { 7850000.0d, 0.0000525613d },
            { 7882000.0d, 0.0000511026d },
            { 7914000.0d, 0.0000496509d },
            { 7946000.0d, 0.0000482068d },
            { 7978000.0d, 0.000046771d },
            { 8010000.0d, 0.000045344d },
            { 8042000.0d, 0.0000439265d },
            { 8074000.0d, 0.000042519d },
            { 8106000.0d, 0.0000411222d },
            { 8138000.0d, 0.0000397367d },
            { 8170000.0d, 0.0000383632d },
            { 8202000.0d, 0.0000370022d },
            { 8234000.0d, 0.0000356545d },
            { 8266000.0d, 0.0000343207d },
            { 8298000.0d, 0.0000330013d },
            { 8330000.0d, 0.0000316972d },
            { 8362000.0d, 0.0000304089d },
            { 8394000.0d, 0.0000291371d },
            { 8426000.0d, 0.0000278825d },
            { 8458000.0d, 0.0000266457d },
            { 8490000.0d, 0.0000254276d },
            { 8522000.0d, 0.0000242285d },
            { 8554000.0d, 0.0000230494d },
            { 8586000.0d, 0.000021891d },
            { 8618000.0d, 0.0000207538d },
            { 8650000.0d, 0.0000196387d },
            { 8682000.0d, 0.0000185463d },
            { 8714000.0d, 0.0000174773d },
            { 8746000.0d, 0.0000164325d },
            { 8778000.0d, 0.0000154126d },
            { 8810000.0d, 0.0000144183d },
            { 8842000.0d, 0.0000134503d },
            { 8874000.0d, 0.0000125094d },
            { 8906000.0d, 0.0000115963d },
            { 8938000.0d, 0.0000107117d },
            { 8970000.0d, 0.00000985657d },
            { 9002000.0d, 0.00000903138d },
            { 9034000.0d, 0.00000823704d },
            { 9066000.0d, 0.00000747427d },
            { 9098000.0d, 0.00000674382d },
            { 9130000.0d, 0.00000604649d },
            { 9162000.0d, 0.00000538301d },
            { 9194000.0d, 0.00000475417d },
            { 9226000.0d, 0.00000416074d },
            { 9258000.0d, 0.00000360349d },
            { 9290000.0d, 0.00000308319d },
            { 9322000.0d, 0.00000260064d },
            { 9354000.0d, 0.00000215658d },
            { 9386000.0d, 0.00000175181d },
            { 9418000.0d, 0.00000138709d },
            { 9450000.0d, 0.00000106319d },
            { 9482000.0d, 0.000000780871d },
            { 9514000.0d, 0.000000540888d },
            { 9546000.0d, 0.000000343974d },
            { 9578000.0d, 0.000000190842d },
            { 9610000.0d, 0.0000000821579d },
            { 9642000.0d, 0.0000000185015d },
            { 9671000.0d, 0d },

        }; 
    }
}
    