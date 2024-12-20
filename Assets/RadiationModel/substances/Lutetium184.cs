using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium184 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium184";
        public override double halfLife { get; } = 19.0d;
        public override double atomicWeight { get; } = 183.96103d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium184()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.2695d, new GammaParticle(107100.0, 0.01158)), new(0.1155d, new GammaParticle(242500.0, 0.00511)), new(0.151720155587d, new GammaParticle(9114.0, 0.13604)), new(0.06404713596833385d, new GammaParticle(54608.0, 0.0227)), new(0.1120880923492017d, new GammaParticle(55786.0, 0.02222)), new(0.036978666718598625d, new GammaParticle(63333.0, 0.01958)), new(0.04685197073246445d, new GammaParticle(64057.0, 0.01936)), new(0.009873304013865832d, new GammaParticle(64935.0, 0.01909)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000674131d },
            { 15000.0d, 0.0000703868d },
            { 30000.0d, 0.0000733191d },
            { 45000.0d, 0.0000762101d },
            { 60000.0d, 0.0000790944d },
            { 75000.0d, 0.0000819954d },
            { 90000.0d, 0.0000849194d },
            { 105000.0d, 0.0000878685d },
            { 120000.0d, 0.0000908432d },
            { 135000.0d, 0.0000938422d },
            { 150000.0d, 0.0000968638d },
            { 165000.0d, 0.0000999061d },
            { 180000.0d, 0.000102967d },
            { 195000.0d, 0.000106045d },
            { 210000.0d, 0.000109137d },
            { 225000.0d, 0.000112243d },
            { 240000.0d, 0.000115359d },
            { 255000.0d, 0.000118485d },
            { 270000.0d, 0.00012162d },
            { 285000.0d, 0.00012476d },
            { 300000.0d, 0.000127905d },
            { 315000.0d, 0.000131054d },
            { 330000.0d, 0.000134205d },
            { 345000.0d, 0.000137357d },
            { 360000.0d, 0.000140509d },
            { 375000.0d, 0.000143659d },
            { 390000.0d, 0.000146807d },
            { 405000.0d, 0.000149951d },
            { 420000.0d, 0.00015309d },
            { 435000.0d, 0.000156222d },
            { 450000.0d, 0.000159349d },
            { 465000.0d, 0.000162467d },
            { 480000.0d, 0.000165576d },
            { 495000.0d, 0.000168675d },
            { 510000.0d, 0.000171764d },
            { 525000.0d, 0.00017484d },
            { 540000.0d, 0.000177905d },
            { 555000.0d, 0.000180956d },
            { 570000.0d, 0.000183993d },
            { 585000.0d, 0.000187015d },
            { 600000.0d, 0.000190021d },
            { 615000.0d, 0.000193011d },
            { 630000.0d, 0.000195984d },
            { 645000.0d, 0.000198938d },
            { 660000.0d, 0.000201874d },
            { 675000.0d, 0.00020479d },
            { 690000.0d, 0.000207687d },
            { 705000.0d, 0.000210563d },
            { 720000.0d, 0.000213417d },
            { 735000.0d, 0.00021625d },
            { 750000.0d, 0.00021906d },
            { 765000.0d, 0.000221846d },
            { 780000.0d, 0.000224609d },
            { 795000.0d, 0.000227348d },
            { 810000.0d, 0.000230062d },
            { 825000.0d, 0.00023275d },
            { 840000.0d, 0.000235413d },
            { 855000.0d, 0.000238049d },
            { 870000.0d, 0.000240658d },
            { 885000.0d, 0.00024324d },
            { 900000.0d, 0.000245794d },
            { 915000.0d, 0.000248319d },
            { 930000.0d, 0.000250815d },
            { 945000.0d, 0.000253282d },
            { 960000.0d, 0.00025572d },
            { 975000.0d, 0.000258127d },
            { 990000.0d, 0.000260504d },
            { 1005000.0d, 0.00026285d },
            { 1021000.0d, 0.000265317d },
            { 1037000.0d, 0.000267749d },
            { 1053000.0d, 0.000270144d },
            { 1069000.0d, 0.000272502d },
            { 1085000.0d, 0.000274823d },
            { 1101000.0d, 0.000277106d },
            { 1117000.0d, 0.00027935d },
            { 1133000.0d, 0.000281556d },
            { 1149000.0d, 0.000283723d },
            { 1165000.0d, 0.00028585d },
            { 1181000.0d, 0.000287938d },
            { 1197000.0d, 0.000289986d },
            { 1213000.0d, 0.000291994d },
            { 1229000.0d, 0.000293962d },
            { 1245000.0d, 0.000295889d },
            { 1261000.0d, 0.000297774d },
            { 1277000.0d, 0.000299617d },
            { 1293000.0d, 0.000301419d },
            { 1309000.0d, 0.00030318d },
            { 1325000.0d, 0.000304898d },
            { 1341000.0d, 0.000306574d },
            { 1357000.0d, 0.000308207d },
            { 1373000.0d, 0.000309797d },
            { 1389000.0d, 0.000311344d },
            { 1405000.0d, 0.000312848d },
            { 1421000.0d, 0.000314309d },
            { 1437000.0d, 0.000315725d },
            { 1453000.0d, 0.000317099d },
            { 1469000.0d, 0.000318429d },
            { 1485000.0d, 0.000319714d },
            { 1501000.0d, 0.000320955d },
            { 1517000.0d, 0.000322153d },
            { 1533000.0d, 0.000323305d },
            { 1549000.0d, 0.000324414d },
            { 1565000.0d, 0.000325478d },
            { 1581000.0d, 0.000326497d },
            { 1597000.0d, 0.000327472d },
            { 1613000.0d, 0.000328402d },
            { 1629000.0d, 0.000329288d },
            { 1645000.0d, 0.000330128d },
            { 1661000.0d, 0.000330924d },
            { 1677000.0d, 0.000331675d },
            { 1693000.0d, 0.000332381d },
            { 1709000.0d, 0.000333042d },
            { 1725000.0d, 0.000333658d },
            { 1741000.0d, 0.00033423d },
            { 1757000.0d, 0.000334757d },
            { 1773000.0d, 0.000335238d },
            { 1789000.0d, 0.000335675d },
            { 1805000.0d, 0.000336068d },
            { 1821000.0d, 0.000336415d },
            { 1837000.0d, 0.000336718d },
            { 1853000.0d, 0.000336976d },
            { 1869000.0d, 0.000337191d },
            { 1885000.0d, 0.000337361d },
            { 1901000.0d, 0.000337486d },
            { 1917000.0d, 0.000337567d },
            { 1933000.0d, 0.000337604d },
            { 1949000.0d, 0.000337597d },
            { 1965000.0d, 0.000337546d },
            { 1981000.0d, 0.000337452d },
            { 1997000.0d, 0.000337314d },
            { 2013000.0d, 0.000337132d },
            { 2029000.0d, 0.000336907d },
            { 2045000.0d, 0.000336639d },
            { 2061000.0d, 0.000336329d },
            { 2077000.0d, 0.000335975d },
            { 2093000.0d, 0.000335579d },
            { 2109000.0d, 0.00033514d },
            { 2125000.0d, 0.000334659d },
            { 2141000.0d, 0.000334137d },
            { 2157000.0d, 0.000333573d },
            { 2173000.0d, 0.000332966d },
            { 2189000.0d, 0.000332319d },
            { 2205000.0d, 0.00033163d },
            { 2221000.0d, 0.0003309d },
            { 2237000.0d, 0.00033013d },
            { 2253000.0d, 0.00032932d },
            { 2269000.0d, 0.000328469d },
            { 2285000.0d, 0.000327578d },
            { 2301000.0d, 0.000326648d },
            { 2317000.0d, 0.000325678d },
            { 2333000.0d, 0.000324669d },
            { 2349000.0d, 0.000323622d },
            { 2365000.0d, 0.000322536d },
            { 2381000.0d, 0.000321412d },
            { 2397000.0d, 0.00032025d },
            { 2413000.0d, 0.00031905d },
            { 2429000.0d, 0.000317813d },
            { 2445000.0d, 0.000316539d },
            { 2461000.0d, 0.000315229d },
            { 2477000.0d, 0.000313883d },
            { 2493000.0d, 0.0003125d },
            { 2509000.0d, 0.000311082d },
            { 2525000.0d, 0.000309628d },
            { 2541000.0d, 0.00030814d },
            { 2557000.0d, 0.000306617d },
            { 2573000.0d, 0.000305061d },
            { 2589000.0d, 0.00030347d },
            { 2605000.0d, 0.000301846d },
            { 2621000.0d, 0.000300189d },
            { 2637000.0d, 0.0002985d },
            { 2653000.0d, 0.000296779d },
            { 2669000.0d, 0.000295025d },
            { 2685000.0d, 0.00029324d },
            { 2701000.0d, 0.000291425d },
            { 2717000.0d, 0.000289579d },
            { 2733000.0d, 0.000287703d },
            { 2749000.0d, 0.000285797d },
            { 2765000.0d, 0.000283861d },
            { 2781000.0d, 0.000281897d },
            { 2797000.0d, 0.000279905d },
            { 2813000.0d, 0.000277884d },
            { 2829000.0d, 0.000275837d },
            { 2845000.0d, 0.000273762d },
            { 2861000.0d, 0.000271661d },
            { 2877000.0d, 0.000269534d },
            { 2893000.0d, 0.000267381d },
            { 2909000.0d, 0.000265203d },
            { 2925000.0d, 0.000263001d },
            { 2941000.0d, 0.000260774d },
            { 2957000.0d, 0.000258525d },
            { 2973000.0d, 0.000256251d },
            { 2989000.0d, 0.000253955d },
            { 3005000.0d, 0.000251637d },
            { 3021000.0d, 0.000249298d },
            { 3037000.0d, 0.000246938d },
            { 3053000.0d, 0.000244556d },
            { 3069000.0d, 0.000242155d },
            { 3085000.0d, 0.000239734d },
            { 3101000.0d, 0.000237296d },
            { 3117000.0d, 0.000234838d },
            { 3133000.0d, 0.000232363d },
            { 3149000.0d, 0.000229869d },
            { 3165000.0d, 0.00022736d },
            { 3181000.0d, 0.000224834d },
            { 3197000.0d, 0.000222293d },
            { 3213000.0d, 0.000219737d },
            { 3229000.0d, 0.000217166d },
            { 3245000.0d, 0.000214582d },
            { 3261000.0d, 0.000211984d },
            { 3277000.0d, 0.000209373d },
            { 3293000.0d, 0.00020675d },
            { 3309000.0d, 0.000204117d },
            { 3325000.0d, 0.000201472d },
            { 3341000.0d, 0.000198816d },
            { 3357000.0d, 0.000196152d },
            { 3373000.0d, 0.000193477d },
            { 3389000.0d, 0.000190794d },
            { 3405000.0d, 0.000188104d },
            { 3421000.0d, 0.000185407d },
            { 3437000.0d, 0.000182703d },
            { 3453000.0d, 0.000179993d },
            { 3469000.0d, 0.000177278d },
            { 3485000.0d, 0.000174558d },
            { 3501000.0d, 0.000171834d },
            { 3517000.0d, 0.000169106d },
            { 3533000.0d, 0.000166376d },
            { 3549000.0d, 0.000163644d },
            { 3565000.0d, 0.00016091d },
            { 3581000.0d, 0.000158175d },
            { 3597000.0d, 0.000155441d },
            { 3613000.0d, 0.000152707d },
            { 3629000.0d, 0.000149974d },
            { 3645000.0d, 0.000147244d },
            { 3661000.0d, 0.000144516d },
            { 3677000.0d, 0.000141791d },
            { 3693000.0d, 0.000139071d },
            { 3709000.0d, 0.000136355d },
            { 3725000.0d, 0.000133644d },
            { 3741000.0d, 0.00013094d },
            { 3757000.0d, 0.000128243d },
            { 3773000.0d, 0.000125552d },
            { 3789000.0d, 0.00012287d },
            { 3805000.0d, 0.000120198d },
            { 3821000.0d, 0.000117534d },
            { 3837000.0d, 0.000114881d },
            { 3853000.0d, 0.000112239d },
            { 3869000.0d, 0.000109609d },
            { 3885000.0d, 0.000106992d },
            { 3901000.0d, 0.000104388d },
            { 3917000.0d, 0.000101797d },
            { 3933000.0d, 0.000099222d },
            { 3949000.0d, 0.0000966621d },
            { 3965000.0d, 0.0000941185d },
            { 3981000.0d, 0.0000915918d },
            { 3997000.0d, 0.000089083d },
            { 4013000.0d, 0.0000865926d },
            { 4029000.0d, 0.0000841215d },
            { 4045000.0d, 0.0000816705d },
            { 4061000.0d, 0.0000792402d },
            { 4077000.0d, 0.0000768315d },
            { 4093000.0d, 0.0000744451d },
            { 4109000.0d, 0.0000720818d },
            { 4125000.0d, 0.0000697424d },
            { 4141000.0d, 0.0000674277d },
            { 4157000.0d, 0.0000651384d },
            { 4173000.0d, 0.0000628754d },
            { 4189000.0d, 0.0000606393d },
            { 4205000.0d, 0.0000584311d },
            { 4221000.0d, 0.0000562515d },
            { 4237000.0d, 0.0000541012d },
            { 4253000.0d, 0.0000519812d },
            { 4269000.0d, 0.0000498922d },
            { 4285000.0d, 0.0000478349d },
            { 4301000.0d, 0.0000458103d },
            { 4317000.0d, 0.000043819d },
            { 4333000.0d, 0.000041862d },
            { 4349000.0d, 0.0000399399d },
            { 4365000.0d, 0.0000380537d },
            { 4381000.0d, 0.0000362042d },
            { 4397000.0d, 0.0000343921d },
            { 4413000.0d, 0.0000326184d },
            { 4429000.0d, 0.0000308838d },
            { 4445000.0d, 0.0000291892d },
            { 4461000.0d, 0.0000275353d },
            { 4477000.0d, 0.000025923d },
            { 4493000.0d, 0.0000243531d },
            { 4509000.0d, 0.0000228264d },
            { 4525000.0d, 0.0000213439d },
            { 4541000.0d, 0.0000199064d },
            { 4557000.0d, 0.0000185145d },
            { 4573000.0d, 0.0000171692d },
            { 4589000.0d, 0.0000158715d },
            { 4605000.0d, 0.000014622d },
            { 4621000.0d, 0.0000134215d },
            { 4637000.0d, 0.0000122711d },
            { 4653000.0d, 0.0000111714d },
            { 4669000.0d, 0.0000101233d },
            { 4685000.0d, 0.00000912765d },
            { 4701000.0d, 0.0000081853d },
            { 4717000.0d, 0.00000729704d },
            { 4733000.0d, 0.00000646366d },
            { 4749000.0d, 0.00000568451d },
            { 4765000.0d, 0.00000495306d },
            { 4781000.0d, 0.00000426902d },
            { 4797000.0d, 0.00000363308d },
            { 4813000.0d, 0.00000304596d },
            { 4829000.0d, 0.00000250835d },
            { 4845000.0d, 0.00000202097d },
            { 4861000.0d, 0.0000015845d },
            { 4877000.0d, 0.00000119962d },
            { 4893000.0d, 0.000000867021d },
            { 4909000.0d, 0.000000587368d },
            { 4925000.0d, 0.000000361303d },
            { 4941000.0d, 0.000000189446d },
            { 4957000.0d, 0.0000000723651d },
            { 4973000.0d, 0.0000000105227d },
            { 4982900.0d, 0d },

        }; 
    }
}
    