using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gold193m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold193m";
        public override double halfLife { get; } = 3.9d;
        public override double atomicWeight { get; } = 192.96445d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9997d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold193()), new(1.0709999999999999e-05d, new GammaParticle(32210.0, 0.03849)), new(0.00053d, new GammaParticle(38220.0, 0.03244)), new(0.0385d, new GammaParticle(219750.0, 0.00564)), new(0.671469d, new GammaParticle(257970.0, 0.00481)), new(0.000262d, new GammaParticle(289800.0, 0.00428)), new(0.33390019365948d, new GammaParticle(11419.0, 0.10858)), new(0.06575905002158877d, new GammaParticle(66991.0, 0.01851)), new(0.11194935311812866d, new GammaParticle(68806.0, 0.01802)), new(0.03777509888307415d, new GammaParticle(78048.0, 0.01589)), new(0.04869210246028257d, new GammaParticle(78983.0, 0.0157)), new(0.010917003577208428d, new GammaParticle(80133.0, 0.01547)) } },
            { 0.0003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium193()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(2.9e-11d, new GammaParticle(1642.0, 0.75508)), new(6.3e-10d, new GammaParticle(12634.0, 0.09814)), new(1.0299999999999999e-10d, new GammaParticle(135400.0, 0.00916)), new(4.858013187e-08d, new GammaParticle(11070.0, 0.112)), new(2.39856465514037e-08d, new GammaParticle(65122.0, 0.01904)), new(4.1001105216074705e-08d, new GammaParticle(66832.0, 0.01855)), new(1.3795787894651325e-08d, new GammaParticle(75821.0, 0.01635)), new(1.7741383232521605e-08d, new GammaParticle(76725.0, 0.01616)), new(3.945595337870278e-09d, new GammaParticle(77832.0, 0.01593)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 600.0d, 0.00000000000000100792d },
            { 1200.0d, 0.00000000000000262064d },
            { 1800.0d, 0.00000000000000518856d },
            { 2400.0d, 0.0000000000000089487d },
            { 3000.0d, 0.0000000000000141475d },
            { 3600.0d, 0.0000000000000210405d },
            { 4200.0d, 0.0000000000000298901d },
            { 4800.0d, 0.0000000000000409637d },
            { 5400.0d, 0.0000000000000545317d },
            { 6000.0d, 0.0000000000000708652d },
            { 6600.0d, 0.0000000000000902348d },
            { 7200.0d, 0.000000000000112909d },
            { 7800.0d, 0.000000000000139151d },
            { 8400.0d, 0.000000000000169222d },
            { 9000.0d, 0.000000000000203374d },
            { 9600.0d, 0.000000000000241853d },
            { 10000.0d, 0.000000000000270042d },
            { 10600.0d, 0.000000000000316257d },
            { 11200.0d, 0.000000000000367413d },
            { 11800.0d, 0.000000000000423723d },
            { 12400.0d, 0.00000000000048539d },
            { 13000.0d, 0.000000000000552603d },
            { 13600.0d, 0.000000000000625544d },
            { 14200.0d, 0.000000000000704379d },
            { 14800.0d, 0.000000000000789266d },
            { 15400.0d, 0.000000000000880349d },
            { 16000.0d, 0.00000000000097776d },
            { 16600.0d, 0.00000000000108162d },
            { 17200.0d, 0.00000000000119204d },
            { 17800.0d, 0.00000000000130912d },
            { 18400.0d, 0.00000000000143293d },
            { 19000.0d, 0.00000000000156356d },
            { 19600.0d, 0.00000000000170107d },
            { 20200.0d, 0.00000000000184549d },
            { 20800.0d, 0.00000000000199687d },
            { 21400.0d, 0.00000000000215525d },
            { 22000.0d, 0.00000000000232064d },
            { 22600.0d, 0.00000000000249304d },
            { 23200.0d, 0.00000000000267246d },
            { 23800.0d, 0.00000000000285887d },
            { 24400.0d, 0.00000000000305226d },
            { 25000.0d, 0.00000000000325259d },
            { 25600.0d, 0.00000000000345982d },
            { 26200.0d, 0.00000000000367391d },
            { 26800.0d, 0.00000000000389479d },
            { 27400.0d, 0.0000000000041224d },
            { 28000.0d, 0.00000000000435666d },
            { 28600.0d, 0.0000000000045975d },
            { 29200.0d, 0.00000000000484483d },
            { 29800.0d, 0.00000000000509854d },
            { 30400.0d, 0.00000000000535854d },
            { 31000.0d, 0.00000000000562471d },
            { 31600.0d, 0.00000000000589696d },
            { 32200.000000000004d, 0.00000000000617516d },
            { 32800.0d, 0.00000000000645917d },
            { 33400.0d, 0.00000000000674888d },
            { 34000.0d, 0.00000000000704415d },
            { 34600.0d, 0.00000000000734483d },
            { 35200.0d, 0.0000000000076508d },
            { 35800.0d, 0.00000000000796189d },
            { 36400.0d, 0.00000000000827796d },
            { 37000.0d, 0.00000000000859886d },
            { 37600.0d, 0.00000000000892443d },
            { 38200.0d, 0.0000000000092545d },
            { 38800.0d, 0.00000000000958891d },
            { 39400.0d, 0.00000000000992752d },
            { 40000.0d, 0.0000000000102701d },
            { 40600.0d, 0.0000000000106166d },
            { 41200.0d, 0.0000000000109667d },
            { 41800.0d, 0.0000000000113203d },
            { 42400.0d, 0.0000000000116772d },
            { 43000.0d, 0.0000000000120373d },
            { 43600.0d, 0.0000000000124003d },
            { 44200.0d, 0.0000000000127662d },
            { 44800.0d, 0.0000000000131346d },
            { 45400.0d, 0.0000000000135055d },
            { 46000.0d, 0.0000000000138786d },
            { 46600.0d, 0.0000000000142538d },
            { 47200.0d, 0.0000000000146309d },
            { 47800.0d, 0.0000000000150097d },
            { 48400.0d, 0.00000000001539d },
            { 49000.0d, 0.0000000000157717d },
            { 49600.0d, 0.0000000000161545d },
            { 50200.0d, 0.0000000000165384d },
            { 50800.0d, 0.0000000000169231d },
            { 51400.0d, 0.0000000000173083d },
            { 52000.0d, 0.0000000000176941d },
            { 52600.0d, 0.0000000000180801d },
            { 53200.0d, 0.0000000000184662d },
            { 53800.0d, 0.0000000000188522d },
            { 54400.0d, 0.0000000000192381d },
            { 55000.0d, 0.0000000000196235d },
            { 55600.0d, 0.0000000000200083d },
            { 56200.0d, 0.0000000000203923d },
            { 56800.0d, 0.0000000000207755d },
            { 57400.0d, 0.0000000000211576d },
            { 58000.0d, 0.0000000000215384d },
            { 58600.0d, 0.0000000000219178d },
            { 59200.0d, 0.0000000000222956d },
            { 59800.0d, 0.0000000000226716d },
            { 60400.0d, 0.0000000000230458d },
            { 61000.0d, 0.0000000000234179d },
            { 61600.0d, 0.0000000000237879d },
            { 62200.0d, 0.0000000000241555d },
            { 62800.0d, 0.0000000000245206d },
            { 63400.0d, 0.0000000000248831d },
            { 64000.0d, 0.0000000000252428d },
            { 64599.99999999999d, 0.0000000000255995d },
            { 65200.0d, 0.0000000000259531d },
            { 65800.0d, 0.0000000000263035d },
            { 66400.0d, 0.0000000000266506d },
            { 67000.0d, 0.0000000000269942d },
            { 67600.0d, 0.0000000000273342d },
            { 68200.0d, 0.0000000000276704d },
            { 68800.0d, 0.0000000000280029d },
            { 69400.0d, 0.0000000000283313d },
            { 70000.0d, 0.0000000000286555d },
            { 70600.0d, 0.0000000000289756d },
            { 71200.0d, 0.0000000000292913d },
            { 71800.0d, 0.0000000000296025d },
            { 72400.0d, 0.0000000000299091d },
            { 73000.0d, 0.0000000000302111d },
            { 73600.0d, 0.0000000000305082d },
            { 74200.0d, 0.0000000000308005d },
            { 74800.0d, 0.0000000000310878d },
            { 75400.0d, 0.00000000003137d },
            { 76000.0d, 0.000000000031647d },
            { 76600.0d, 0.0000000000319186d },
            { 77200.0d, 0.0000000000321849d },
            { 77800.0d, 0.0000000000324457d },
            { 78400.0d, 0.0000000000327009d },
            { 79000.0d, 0.0000000000329506d },
            { 79600.0d, 0.0000000000331945d },
            { 80200.0d, 0.0000000000334326d },
            { 80800.0d, 0.0000000000336648d },
            { 81400.0d, 0.0000000000338911d },
            { 82000.0d, 0.0000000000341113d },
            { 82600.0d, 0.0000000000343255d },
            { 83200.0d, 0.0000000000345335d },
            { 83800.0d, 0.0000000000347352d },
            { 84400.0d, 0.0000000000349306d },
            { 85000.0d, 0.0000000000351198d },
            { 85600.0d, 0.0000000000353025d },
            { 86200.0d, 0.0000000000354787d },
            { 86800.0d, 0.0000000000356484d },
            { 87400.0d, 0.0000000000358117d },
            { 88000.0d, 0.0000000000359683d },
            { 88600.0d, 0.0000000000361182d },
            { 89200.0d, 0.0000000000362614d },
            { 89800.0d, 0.000000000036398d },
            { 90400.0d, 0.0000000000365278d },
            { 91000.0d, 0.0000000000366507d },
            { 91600.0d, 0.0000000000367668d },
            { 92200.0d, 0.0000000000368761d },
            { 92800.0d, 0.0000000000369784d },
            { 93400.0d, 0.0000000000370739d },
            { 94000.0d, 0.0000000000371624d },
            { 94600.0d, 0.000000000037244d },
            { 95200.0d, 0.0000000000373186d },
            { 95800.0d, 0.0000000000373862d },
            { 96400.0d, 0.0000000000374467d },
            { 97000.0d, 0.0000000000375003d },
            { 97600.0d, 0.0000000000375468d },
            { 98200.0d, 0.0000000000375864d },
            { 98800.0d, 0.0000000000376189d },
            { 99400.0d, 0.0000000000376444d },
            { 100000.0d, 0.0000000000376628d },
            { 100600.0d, 0.0000000000376742d },
            { 101200.0d, 0.0000000000376785d },
            { 101800.0d, 0.0000000000376758d },
            { 102400.0d, 0.0000000000376662d },
            { 103000.0d, 0.0000000000376495d },
            { 103600.0d, 0.0000000000376258d },
            { 104200.0d, 0.0000000000375952d },
            { 104800.0d, 0.0000000000375576d },
            { 105400.0d, 0.0000000000375131d },
            { 106000.0d, 0.0000000000374616d },
            { 106600.0d, 0.0000000000374033d },
            { 107200.0d, 0.0000000000373381d },
            { 107800.0d, 0.000000000037266d },
            { 108400.0d, 0.0000000000371872d },
            { 109000.0d, 0.0000000000371016d },
            { 109600.0d, 0.0000000000370092d },
            { 110200.0d, 0.0000000000369101d },
            { 110800.0d, 0.0000000000368044d },
            { 111400.0d, 0.000000000036692d },
            { 112000.0d, 0.0000000000365731d },
            { 112600.0d, 0.0000000000364476d },
            { 113200.0d, 0.0000000000363156d },
            { 113800.0d, 0.0000000000361772d },
            { 114400.0d, 0.0000000000360323d },
            { 115000.0d, 0.0000000000358811d },
            { 115600.0d, 0.0000000000357236d },
            { 116200.0d, 0.0000000000355599d },
            { 116800.0d, 0.00000000003539d },
            { 117400.0d, 0.000000000035214d },
            { 118000.0d, 0.0000000000350318d },
            { 118600.0d, 0.0000000000348436d },
            { 119200.0d, 0.0000000000346496d },
            { 119800.0d, 0.0000000000344497d },
            { 120400.0d, 0.0000000000342439d },
            { 121000.0d, 0.0000000000340324d },
            { 121600.0d, 0.0000000000338152d },
            { 122200.0d, 0.0000000000335924d },
            { 122800.0d, 0.0000000000333641d },
            { 123400.0d, 0.0000000000331304d },
            { 124000.0d, 0.0000000000328913d },
            { 124600.0d, 0.0000000000326469d },
            { 125200.0d, 0.0000000000323972d },
            { 125800.0d, 0.0000000000321425d },
            { 126400.0d, 0.0000000000318826d },
            { 127000.0d, 0.0000000000316178d },
            { 127600.0d, 0.0000000000313482d },
            { 128199.99999999999d, 0.0000000000310738d },
            { 128800.00000000001d, 0.0000000000307947d },
            { 129400.0d, 0.0000000000305109d },
            { 130000.0d, 0.0000000000302227d },
            { 130600.0d, 0.00000000002993d },
            { 131200.0d, 0.0000000000296329d },
            { 131800.0d, 0.0000000000293317d },
            { 132400.0d, 0.0000000000290263d },
            { 133000.0d, 0.0000000000287169d },
            { 133600.0d, 0.0000000000284036d },
            { 134200.0d, 0.0000000000280865d },
            { 134800.0d, 0.0000000000277656d },
            { 135400.0d, 0.0000000000274411d },
            { 136000.0d, 0.0000000000271131d },
            { 136600.0d, 0.0000000000267817d },
            { 137200.0d, 0.0000000000264471d },
            { 137800.0d, 0.0000000000261092d },
            { 138400.0d, 0.0000000000257682d },
            { 139000.0d, 0.0000000000254243d },
            { 139600.0d, 0.0000000000250777d },
            { 140200.0d, 0.0000000000247283d },
            { 140800.0d, 0.0000000000243762d },
            { 141400.0d, 0.0000000000240216d },
            { 142000.0d, 0.0000000000236647d },
            { 142600.0d, 0.0000000000233056d },
            { 143200.0d, 0.0000000000229444d },
            { 143800.0d, 0.0000000000225811d },
            { 144400.0d, 0.000000000022216d },
            { 145000.0d, 0.0000000000218492d },
            { 145600.0d, 0.0000000000214807d },
            { 146200.0d, 0.0000000000211108d },
            { 146800.0d, 0.0000000000207394d },
            { 147400.0d, 0.0000000000203669d },
            { 148000.0d, 0.0000000000199933d },
            { 148600.0d, 0.0000000000196187d },
            { 149200.0d, 0.0000000000192433d },
            { 149800.0d, 0.0000000000188672d },
            { 150400.0d, 0.0000000000184906d },
            { 151000.0d, 0.0000000000181135d },
            { 151600.0d, 0.0000000000177361d },
            { 152200.0d, 0.0000000000173586d },
            { 152800.0d, 0.0000000000169812d },
            { 153400.0d, 0.0000000000166039d },
            { 154000.0d, 0.0000000000162268d },
            { 154600.0d, 0.0000000000158502d },
            { 155200.0d, 0.0000000000154742d },
            { 155800.0d, 0.000000000015099d },
            { 156400.0d, 0.0000000000147246d },
            { 157000.0d, 0.0000000000143512d },
            { 157600.0d, 0.000000000013979d },
            { 158200.0d, 0.0000000000136081d },
            { 158800.0d, 0.0000000000132388d },
            { 159400.0d, 0.000000000012871d },
            { 160000.0d, 0.0000000000125051d },
            { 160600.0d, 0.000000000012141d },
            { 161200.0d, 0.0000000000117791d },
            { 161800.0d, 0.0000000000114194d },
            { 162400.0d, 0.0000000000110621d },
            { 163000.0d, 0.0000000000107074d },
            { 163600.0d, 0.0000000000103555d },
            { 164200.0d, 0.0000000000100064d },
            { 164800.0d, 0.00000000000966036d },
            { 165400.0d, 0.00000000000931754d },
            { 166000.0d, 0.00000000000897809d },
            { 166600.0d, 0.00000000000864218d },
            { 167200.0d, 0.00000000000830998d },
            { 167800.0d, 0.00000000000798165d },
            { 168400.0d, 0.00000000000765735d },
            { 169000.0d, 0.00000000000733726d },
            { 169600.0d, 0.00000000000702153d },
            { 170200.0d, 0.00000000000671035d },
            { 170800.0d, 0.00000000000640388d },
            { 171400.0d, 0.00000000000610229d },
            { 172000.0d, 0.00000000000580576d },
            { 172600.0d, 0.00000000000551444d },
            { 173200.0d, 0.00000000000522853d },
            { 173800.0d, 0.0000000000049482d },
            { 174400.0d, 0.00000000000467361d },
            { 175000.0d, 0.00000000000440494d },
            { 175600.0d, 0.00000000000414237d },
            { 176200.0d, 0.00000000000388608d },
            { 176800.0d, 0.00000000000363624d },
            { 177400.0d, 0.00000000000339304d },
            { 178000.0d, 0.00000000000315665d },
            { 178600.0d, 0.00000000000292725d },
            { 179200.0d, 0.00000000000270503d },
            { 179800.0d, 0.00000000000249017d },
            { 180400.0d, 0.00000000000228284d },
            { 181000.0d, 0.00000000000208323d },
            { 181600.0d, 0.00000000000189153d },
            { 182200.0d, 0.00000000000170791d },
            { 182800.0d, 0.00000000000153257d },
            { 183400.0d, 0.00000000000136569d },
            { 184000.0d, 0.00000000000120746d },
            { 184600.0d, 0.00000000000105806d },
            { 185200.0d, 0.000000000000917677d },
            { 185800.0d, 0.000000000000786508d },
            { 186400.0d, 0.000000000000664736d },
            { 187000.0d, 0.00000000000055255d },
            { 187600.0d, 0.000000000000450143d },
            { 188200.0d, 0.000000000000357704d },
            { 188800.0d, 0.000000000000275424d },
            { 189400.0d, 0.000000000000203494d },
            { 190000.0d, 0.000000000000142107d },
            { 190600.0d, 0.000000000000091453d },
            { 191200.0d, 0.0000000000000517258d },
            { 191800.0d, 0.0000000000000231166d },
            { 192400.0d, 0.00000000000000581624d },
            { 193000.0d, 0d },
            { 193000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    