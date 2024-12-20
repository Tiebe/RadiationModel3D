using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Strontium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium99";
        public override double halfLife { get; } = 0.269d;
        public override double atomicWeight { get; } = 98.93288d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium99()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.013515d, new GammaParticle(63850.0, 0.01942)), new(0.018126d, new GammaParticle(120580.0, 0.01028)), new(0.159d, new GammaParticle(125120.0, 0.00991)), new(0.017013d, new GammaParticle(158620.0, 0.00782)), new(0.007314d, new GammaParticle(160730.0, 0.00771)), new(0.0050880000000000005d, new GammaParticle(169560.0, 0.00731)), new(0.001113d, new GammaParticle(198470.0, 0.00625)), new(0.0012720000000000001d, new GammaParticle(210050.0, 0.0059)), new(0.00159d, new GammaParticle(283680.0, 0.00437)), new(0.003816d, new GammaParticle(330300.0, 0.00375)), new(0.002067d, new GammaParticle(340810.0, 0.00364)), new(0.0002385d, new GammaParticle(357200.0, 0.00347)), new(0.00477d, new GammaParticle(362110.0, 0.00342)), new(0.0012720000000000001d, new GammaParticle(395000.0, 0.00314)), new(0.010017d, new GammaParticle(462700.0, 0.00268)), new(0.013515d, new GammaParticle(475590.0, 0.00261)), new(0.045315d, new GammaParticle(487310.0, 0.00254)), new(0.007632d, new GammaParticle(499260.0, 0.00248)), new(0.029733d, new GammaParticle(531750.0, 0.00233)), new(0.006836999999999999d, new GammaParticle(533900.0, 0.00232)), new(0.13833d, new GammaParticle(536120.0, 0.00231)), new(0.0012720000000000001d, new GammaParticle(556400.0, 0.00223)), new(0.00954d, new GammaParticle(583430.0, 0.00213)), new(0.000795d, new GammaParticle(589000.0, 0.0021)), new(0.007314d, new GammaParticle(624320.0, 0.00199)), new(0.0027029999999999997d, new GammaParticle(632320.0, 0.00196)), new(0.00318d, new GammaParticle(657170.0, 0.00189)), new(0.008745000000000001d, new GammaParticle(661580.0, 0.00187)), new(0.003498d, new GammaParticle(676870.0, 0.00183)), new(0.000954d, new GammaParticle(692000.0, 0.00179)), new(0.002385d, new GammaParticle(726000.0, 0.00171)), new(0.002385d, new GammaParticle(732300.0, 0.00169)), new(0.001431d, new GammaParticle(740100.0, 0.00168)), new(0.001749d, new GammaParticle(802700.0, 0.00154)), new(0.0006360000000000001d, new GammaParticle(817000.0, 0.00152)), new(0.005247000000000001d, new GammaParticle(875440.0, 0.00142)), new(0.001431d, new GammaParticle(922000.0, 0.00134)), new(0.004452d, new GammaParticle(936930.0, 0.00132)), new(0.004929d, new GammaParticle(1008000.0, 0.00123)), new(0.017172d, new GammaParticle(1009120.0, 0.00123)), new(0.00159d, new GammaParticle(1041700.0, 0.00119)), new(0.041498999999999994d, new GammaParticle(1047350.0, 0.00118)), new(0.013356d, new GammaParticle(1066480.0, 0.00116)), new(0.00159d, new GammaParticle(1088000.0, 0.00114)), new(0.006042d, new GammaParticle(1095520.0, 0.00113)), new(0.007314d, new GammaParticle(1117100.0, 0.00111)), new(0.00159d, new GammaParticle(1119000.0, 0.00111)), new(0.005565d, new GammaParticle(1191280.0, 0.00104)), new(0.009699d, new GammaParticle(1195280.0, 0.00104)), new(0.09063d, new GammaParticle(1198120.0, 0.00103)), new(0.00159d, new GammaParticle(1213000.0, 0.00102)), new(0.003021d, new GammaParticle(1264620.0, 0.00098)), new(0.007155d, new GammaParticle(1276950.0, 0.00097)), new(0.005724d, new GammaParticle(1388440.0, 0.00089)), new(0.011766d, new GammaParticle(1402160.0, 0.00088)), new(0.016059d, new GammaParticle(1411740.0, 0.00088)), new(0.00477d, new GammaParticle(1421540.0, 0.00087)), new(0.006996d, new GammaParticle(1443440.0, 0.00086)), new(0.008268d, new GammaParticle(1548890.0, 0.0008)), new(0.003657d, new GammaParticle(1581000.0, 0.00078)), new(0.00477d, new GammaParticle(1582600.0, 0.00078)), new(0.015582d, new GammaParticle(1619230.0, 0.00077)), new(0.00318d, new GammaParticle(1623000.0, 0.00076)), new(0.0046110000000000005d, new GammaParticle(1669800.0, 0.00074)), new(0.0046110000000000005d, new GammaParticle(1703280.0, 0.00073)), new(0.008904d, new GammaParticle(1718840.0, 0.00072)), new(0.015105d, new GammaParticle(1739820.0, 0.00071)), new(0.01113d, new GammaParticle(1743600.0, 0.00071)), new(0.007314d, new GammaParticle(1758140.0, 0.00071)), new(0.006996d, new GammaParticle(1793000.0, 0.00069)), new(0.010335d, new GammaParticle(1805720.0, 0.00069)), new(0.014787d, new GammaParticle(1930680.0, 0.00064)), new(0.055650000000000005d, new GammaParticle(2080380.0, 0.0006)), new(0.010335d, new GammaParticle(2114400.0, 0.00059)), new(0.00954d, new GammaParticle(2154600.0, 0.00058)), new(0.006836999999999999d, new GammaParticle(2206100.0, 0.00056)), new(0.07314d, new GammaParticle(2239280.0, 0.00055)), new(0.003498d, new GammaParticle(2245300.0, 0.00055)), new(0.011607000000000001d, new GammaParticle(2276000.0, 0.00054)), new(0.07473d, new GammaParticle(2279420.0, 0.00054)), new(0.000721508769094764d, new GammaParticle(2027.0, 0.61166)), new(0.004281704608377327d, new GammaParticle(14883.0, 0.08331)), new(0.008210363582698613d, new GammaParticle(14958.0, 0.08289)), new(0.0020615205679121807d, new GammaParticle(16803.0, 0.07379)), new(0.0023460104062840615d, new GammaParticle(16880.0, 0.07345)), new(0.00028448983837188094d, new GammaParticle(17011.0, 0.07288)) } },
            { 0.001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium99()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.013515d, new GammaParticle(63850.0, 0.01942)), new(0.018126d, new GammaParticle(120580.0, 0.01028)), new(0.159d, new GammaParticle(125120.0, 0.00991)), new(0.017013d, new GammaParticle(158620.0, 0.00782)), new(0.007314d, new GammaParticle(160730.0, 0.00771)), new(0.0050880000000000005d, new GammaParticle(169560.0, 0.00731)), new(0.001113d, new GammaParticle(198470.0, 0.00625)), new(0.0012720000000000001d, new GammaParticle(210050.0, 0.0059)), new(0.00159d, new GammaParticle(283680.0, 0.00437)), new(0.003816d, new GammaParticle(330300.0, 0.00375)), new(0.002067d, new GammaParticle(340810.0, 0.00364)), new(0.0002385d, new GammaParticle(357200.0, 0.00347)), new(0.00477d, new GammaParticle(362110.0, 0.00342)), new(0.0012720000000000001d, new GammaParticle(395000.0, 0.00314)), new(0.010017d, new GammaParticle(462700.0, 0.00268)), new(0.013515d, new GammaParticle(475590.0, 0.00261)), new(0.045315d, new GammaParticle(487310.0, 0.00254)), new(0.007632d, new GammaParticle(499260.0, 0.00248)), new(0.029733d, new GammaParticle(531750.0, 0.00233)), new(0.006836999999999999d, new GammaParticle(533900.0, 0.00232)), new(0.13833d, new GammaParticle(536120.0, 0.00231)), new(0.0012720000000000001d, new GammaParticle(556400.0, 0.00223)), new(0.00954d, new GammaParticle(583430.0, 0.00213)), new(0.000795d, new GammaParticle(589000.0, 0.0021)), new(0.007314d, new GammaParticle(624320.0, 0.00199)), new(0.0027029999999999997d, new GammaParticle(632320.0, 0.00196)), new(0.00318d, new GammaParticle(657170.0, 0.00189)), new(0.008745000000000001d, new GammaParticle(661580.0, 0.00187)), new(0.003498d, new GammaParticle(676870.0, 0.00183)), new(0.000954d, new GammaParticle(692000.0, 0.00179)), new(0.002385d, new GammaParticle(726000.0, 0.00171)), new(0.002385d, new GammaParticle(732300.0, 0.00169)), new(0.001431d, new GammaParticle(740100.0, 0.00168)), new(0.001749d, new GammaParticle(802700.0, 0.00154)), new(0.0006360000000000001d, new GammaParticle(817000.0, 0.00152)), new(0.005247000000000001d, new GammaParticle(875440.0, 0.00142)), new(0.001431d, new GammaParticle(922000.0, 0.00134)), new(0.004452d, new GammaParticle(936930.0, 0.00132)), new(0.004929d, new GammaParticle(1008000.0, 0.00123)), new(0.017172d, new GammaParticle(1009120.0, 0.00123)), new(0.00159d, new GammaParticle(1041700.0, 0.00119)), new(0.041498999999999994d, new GammaParticle(1047350.0, 0.00118)), new(0.013356d, new GammaParticle(1066480.0, 0.00116)), new(0.00159d, new GammaParticle(1088000.0, 0.00114)), new(0.006042d, new GammaParticle(1095520.0, 0.00113)), new(0.007314d, new GammaParticle(1117100.0, 0.00111)), new(0.00159d, new GammaParticle(1119000.0, 0.00111)), new(0.005565d, new GammaParticle(1191280.0, 0.00104)), new(0.009699d, new GammaParticle(1195280.0, 0.00104)), new(0.09063d, new GammaParticle(1198120.0, 0.00103)), new(0.00159d, new GammaParticle(1213000.0, 0.00102)), new(0.003021d, new GammaParticle(1264620.0, 0.00098)), new(0.007155d, new GammaParticle(1276950.0, 0.00097)), new(0.005724d, new GammaParticle(1388440.0, 0.00089)), new(0.011766d, new GammaParticle(1402160.0, 0.00088)), new(0.016059d, new GammaParticle(1411740.0, 0.00088)), new(0.00477d, new GammaParticle(1421540.0, 0.00087)), new(0.006996d, new GammaParticle(1443440.0, 0.00086)), new(0.008268d, new GammaParticle(1548890.0, 0.0008)), new(0.003657d, new GammaParticle(1581000.0, 0.00078)), new(0.00477d, new GammaParticle(1582600.0, 0.00078)), new(0.015582d, new GammaParticle(1619230.0, 0.00077)), new(0.00318d, new GammaParticle(1623000.0, 0.00076)), new(0.0046110000000000005d, new GammaParticle(1669800.0, 0.00074)), new(0.0046110000000000005d, new GammaParticle(1703280.0, 0.00073)), new(0.008904d, new GammaParticle(1718840.0, 0.00072)), new(0.015105d, new GammaParticle(1739820.0, 0.00071)), new(0.01113d, new GammaParticle(1743600.0, 0.00071)), new(0.007314d, new GammaParticle(1758140.0, 0.00071)), new(0.006996d, new GammaParticle(1793000.0, 0.00069)), new(0.010335d, new GammaParticle(1805720.0, 0.00069)), new(0.014787d, new GammaParticle(1930680.0, 0.00064)), new(0.055650000000000005d, new GammaParticle(2080380.0, 0.0006)), new(0.010335d, new GammaParticle(2114400.0, 0.00059)), new(0.00954d, new GammaParticle(2154600.0, 0.00058)), new(0.006836999999999999d, new GammaParticle(2206100.0, 0.00056)), new(0.07314d, new GammaParticle(2239280.0, 0.00055)), new(0.003498d, new GammaParticle(2245300.0, 0.00055)), new(0.011607000000000001d, new GammaParticle(2276000.0, 0.00054)), new(0.07473d, new GammaParticle(2279420.0, 0.00054)), new(0.000721508769094764d, new GammaParticle(2027.0, 0.61166)), new(0.004281704608377327d, new GammaParticle(14883.0, 0.08331)), new(0.008210363582698613d, new GammaParticle(14958.0, 0.08289)), new(0.0020615205679121807d, new GammaParticle(16803.0, 0.07379)), new(0.0023460104062840615d, new GammaParticle(16880.0, 0.07345)), new(0.00028448983837188094d, new GammaParticle(17011.0, 0.07288)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000203109d },
            { 19000.0d, 0.0000215197d },
            { 38000.0d, 0.0000228523d },
            { 57000.0d, 0.0000243088d },
            { 76000.0d, 0.0000258612d },
            { 95000.0d, 0.0000274783d },
            { 114000.0d, 0.0000291447d },
            { 133000.0d, 0.0000308515d },
            { 152000.0d, 0.0000325933d },
            { 171000.0d, 0.0000343668d },
            { 190000.0d, 0.0000361691d },
            { 209000.0d, 0.0000379982d },
            { 228000.0d, 0.0000398526d },
            { 247000.0d, 0.0000417309d },
            { 266000.0d, 0.0000436317d },
            { 285000.0d, 0.000045554d },
            { 304000.0d, 0.0000474967d },
            { 323000.0d, 0.0000494589d },
            { 342000.0d, 0.0000514396d },
            { 361000.0d, 0.0000534379d },
            { 380000.0d, 0.0000554529d },
            { 399000.0d, 0.0000574838d },
            { 418000.0d, 0.0000595297d },
            { 437000.0d, 0.0000615899d },
            { 456000.0d, 0.0000636634d },
            { 475000.0d, 0.0000657496d },
            { 494000.0d, 0.0000678475d },
            { 513000.0d, 0.0000699565d },
            { 532000.0d, 0.0000720759d },
            { 551000.0d, 0.0000742048d },
            { 570000.0d, 0.0000763424d },
            { 589000.0d, 0.0000784881d },
            { 608000.0d, 0.0000806411d },
            { 627000.0d, 0.0000828008d },
            { 646000.0d, 0.0000849666d },
            { 665000.0d, 0.0000871374d },
            { 684000.0d, 0.0000893128d },
            { 703000.0d, 0.0000914922d },
            { 722000.0d, 0.0000936747d },
            { 741000.0d, 0.0000958598d },
            { 760000.0d, 0.0000980468d },
            { 779000.0d, 0.000100235d },
            { 798000.0d, 0.000102424d },
            { 817000.0d, 0.000104613d },
            { 836000.0d, 0.000106801d },
            { 855000.0d, 0.000108989d },
            { 874000.0d, 0.000111174d },
            { 893000.0d, 0.000113357d },
            { 912000.0d, 0.000115537d },
            { 931000.0d, 0.000117713d },
            { 950000.0d, 0.000119885d },
            { 969000.0d, 0.000122053d },
            { 988000.0d, 0.000124215d },
            { 1007000.0d, 0.000126371d },
            { 1034000.0d, 0.000129425d },
            { 1061000.0d, 0.000132464d },
            { 1088000.0d, 0.000135487d },
            { 1115000.0d, 0.000138493d },
            { 1142000.0d, 0.000141481d },
            { 1169000.0d, 0.000144448d },
            { 1196000.0d, 0.000147394d },
            { 1223000.0d, 0.000150317d },
            { 1250000.0d, 0.000153216d },
            { 1277000.0d, 0.00015609d },
            { 1304000.0d, 0.000158937d },
            { 1331000.0d, 0.000161756d },
            { 1358000.0d, 0.000164546d },
            { 1385000.0d, 0.000167306d },
            { 1412000.0d, 0.000170035d },
            { 1439000.0d, 0.000172731d },
            { 1466000.0d, 0.000175394d },
            { 1493000.0d, 0.000178022d },
            { 1520000.0d, 0.000180614d },
            { 1547000.0d, 0.00018317d },
            { 1574000.0d, 0.000185688d },
            { 1601000.0d, 0.000188167d },
            { 1628000.0d, 0.000190607d },
            { 1655000.0d, 0.000193007d },
            { 1682000.0d, 0.000195365d },
            { 1709000.0d, 0.000197682d },
            { 1736000.0d, 0.000199955d },
            { 1763000.0d, 0.000202185d },
            { 1790000.0d, 0.00020437d },
            { 1817000.0d, 0.000206509d },
            { 1844000.0d, 0.000208603d },
            { 1871000.0d, 0.00021065d },
            { 1898000.0d, 0.00021265d },
            { 1925000.0d, 0.000214602d },
            { 1952000.0d, 0.000216505d },
            { 1979000.0d, 0.000218359d },
            { 2006000.0d, 0.000220163d },
            { 2033000.0d, 0.000221916d },
            { 2060000.0d, 0.000223619d },
            { 2087000.0d, 0.00022527d },
            { 2114000.0d, 0.00022687d },
            { 2141000.0d, 0.000228417d },
            { 2168000.0d, 0.000229911d },
            { 2195000.0d, 0.000231352d },
            { 2222000.0d, 0.000232739d },
            { 2249000.0d, 0.000234072d },
            { 2276000.0d, 0.000235351d },
            { 2303000.0d, 0.000236575d },
            { 2330000.0d, 0.000237745d },
            { 2357000.0d, 0.000238859d },
            { 2384000.0d, 0.000239917d },
            { 2411000.0d, 0.00024092d },
            { 2438000.0d, 0.000241866d },
            { 2465000.0d, 0.000242757d },
            { 2492000.0d, 0.000243591d },
            { 2519000.0d, 0.000244369d },
            { 2546000.0d, 0.00024509d },
            { 2573000.0d, 0.000245754d },
            { 2600000.0d, 0.000246362d },
            { 2627000.0d, 0.000246912d },
            { 2654000.0d, 0.000247406d },
            { 2681000.0d, 0.000247842d },
            { 2708000.0d, 0.000248222d },
            { 2735000.0d, 0.000248545d },
            { 2762000.0d, 0.00024881d },
            { 2789000.0d, 0.000249019d },
            { 2816000.0d, 0.000249171d },
            { 2843000.0d, 0.000249267d },
            { 2870000.0d, 0.000249305d },
            { 2897000.0d, 0.000249288d },
            { 2924000.0d, 0.000249214d },
            { 2951000.0d, 0.000249084d },
            { 2978000.0d, 0.000248898d },
            { 3005000.0d, 0.000248656d },
            { 3032000.0d, 0.000248359d },
            { 3059000.0d, 0.000248006d },
            { 3086000.0d, 0.000247599d },
            { 3113000.0d, 0.000247137d },
            { 3140000.0d, 0.000246621d },
            { 3167000.0d, 0.000246051d },
            { 3194000.0d, 0.000245427d },
            { 3221000.0d, 0.00024475d },
            { 3248000.0d, 0.00024402d },
            { 3275000.0d, 0.000243238d },
            { 3302000.0d, 0.000242403d },
            { 3329000.0d, 0.000241517d },
            { 3356000.0d, 0.00024058d },
            { 3383000.0d, 0.000239593d },
            { 3410000.0d, 0.000238555d },
            { 3437000.0d, 0.000237468d },
            { 3464000.0d, 0.000236331d },
            { 3491000.0d, 0.000235146d },
            { 3518000.0d, 0.000233914d },
            { 3545000.0d, 0.000232634d },
            { 3572000.0d, 0.000231307d },
            { 3599000.0d, 0.000229934d },
            { 3626000.0d, 0.000228516d },
            { 3653000.0d, 0.000227053d },
            { 3680000.0d, 0.000225547d },
            { 3707000.0d, 0.000223996d },
            { 3734000.0d, 0.000222404d },
            { 3761000.0d, 0.000220769d },
            { 3788000.0d, 0.000219093d },
            { 3815000.0d, 0.000217377d },
            { 3842000.0d, 0.000215622d },
            { 3869000.0d, 0.000213828d },
            { 3896000.0d, 0.000211996d },
            { 3923000.0d, 0.000210127d },
            { 3950000.0d, 0.000208221d },
            { 3977000.0d, 0.000206281d },
            { 4004000.0d, 0.000204306d },
            { 4031000.0d, 0.000202298d },
            { 4058000.0d, 0.000200257d },
            { 4085000.0d, 0.000198185d },
            { 4112000.0d, 0.000196082d },
            { 4139000.0d, 0.00019395d },
            { 4166000.0d, 0.000191789d },
            { 4193000.0d, 0.0001896d },
            { 4220000.0d, 0.000187385d },
            { 4247000.0d, 0.000185145d },
            { 4274000.0d, 0.00018288d },
            { 4301000.0d, 0.000180592d },
            { 4328000.0d, 0.000178281d },
            { 4355000.0d, 0.00017595d },
            { 4382000.0d, 0.000173599d },
            { 4409000.0d, 0.000171229d },
            { 4436000.0d, 0.000168841d },
            { 4463000.0d, 0.000166437d },
            { 4490000.0d, 0.000164018d },
            { 4517000.0d, 0.000161585d },
            { 4544000.0d, 0.000159139d },
            { 4571000.0d, 0.000156682d },
            { 4598000.0d, 0.000154215d },
            { 4625000.0d, 0.000151738d },
            { 4652000.0d, 0.000149254d },
            { 4679000.0d, 0.000146764d },
            { 4706000.0d, 0.000144269d },
            { 4733000.0d, 0.00014177d },
            { 4760000.0d, 0.00013927d },
            { 4787000.0d, 0.000136768d },
            { 4814000.0d, 0.000134267d },
            { 4841000.0d, 0.000131768d },
            { 4868000.0d, 0.000129272d },
            { 4895000.0d, 0.000126781d },
            { 4922000.0d, 0.000124297d },
            { 4949000.0d, 0.00012182d },
            { 4976000.0d, 0.000119353d },
            { 5003000.0d, 0.000116896d },
            { 5030000.0d, 0.000114452d },
            { 5057000.0d, 0.000112022d },
            { 5084000.0d, 0.000109607d },
            { 5111000.0d, 0.000107209d },
            { 5138000.0d, 0.00010483d },
            { 5165000.0d, 0.000102471d },
            { 5192000.0d, 0.000100134d },
            { 5219000.0d, 0.0000978202d },
            { 5246000.0d, 0.0000955316d },
            { 5273000.0d, 0.0000932697d },
            { 5300000.0d, 0.0000910363d },
            { 5327000.0d, 0.000088833d },
            { 5354000.0d, 0.0000866614d },
            { 5381000.0d, 0.0000845234d },
            { 5408000.0d, 0.0000824207d },
            { 5435000.0d, 0.0000803549d },
            { 5462000.0d, 0.0000783279d },
            { 5489000.0d, 0.0000763414d },
            { 5516000.0d, 0.0000743971d },
            { 5543000.0d, 0.0000724968d },
            { 5570000.0d, 0.0000706425d },
            { 5597000.0d, 0.0000688359d },
            { 5624000.0d, 0.0000670787d },
            { 5651000.0d, 0.0000653728d },
            { 5678000.0d, 0.00006372d },
            { 5705000.0d, 0.0000621221d },
            { 5732000.0d, 0.0000605811d },
            { 5759000.0d, 0.0000590987d },
            { 5786000.0d, 0.0000576767d },
            { 5813000.0d, 0.000056317d },
            { 5840000.0d, 0.0000550197d },
            { 5867000.0d, 0.0000537802d },
            { 5894000.0d, 0.0000525825d },
            { 5921000.0d, 0.0000514111d },
            { 5948000.0d, 0.0000502538d },
            { 5975000.0d, 0.0000491037d },
            { 6002000.0d, 0.0000479614d },
            { 6029000.0d, 0.0000468273d },
            { 6056000.0d, 0.0000457021d },
            { 6083000.0d, 0.0000445864d },
            { 6110000.0d, 0.0000434807d },
            { 6137000.0d, 0.0000423855d },
            { 6164000.0d, 0.0000413016d },
            { 6191000.0d, 0.0000402295d },
            { 6218000.0d, 0.0000391684d },
            { 6245000.0d, 0.0000381155d },
            { 6272000.0d, 0.0000370713d },
            { 6299000.0d, 0.0000360364d },
            { 6326000.0d, 0.0000350113d },
            { 6353000.0d, 0.0000339965d },
            { 6380000.0d, 0.0000329927d },
            { 6407000.0d, 0.0000320002d },
            { 6434000.0d, 0.0000310197d },
            { 6461000.0d, 0.0000300516d },
            { 6488000.0d, 0.0000290967d },
            { 6515000.0d, 0.0000281555d },
            { 6542000.0d, 0.0000272284d },
            { 6569000.0d, 0.0000263162d },
            { 6596000.0d, 0.0000254193d },
            { 6623000.0d, 0.0000245383d },
            { 6650000.0d, 0.000023674d },
            { 6677000.0d, 0.0000228267d },
            { 6704000.0d, 0.0000219971d },
            { 6731000.0d, 0.0000211854d },
            { 6758000.0d, 0.000020389d },
            { 6785000.0d, 0.0000196077d },
            { 6812000.0d, 0.0000188419d },
            { 6839000.0d, 0.0000180921d },
            { 6866000.0d, 0.0000173588d },
            { 6893000.0d, 0.0000166427d },
            { 6920000.0d, 0.0000159442d },
            { 6947000.0d, 0.0000152629d },
            { 6974000.0d, 0.0000145955d },
            { 7001000.0d, 0.0000139418d },
            { 7028000.0d, 0.0000133022d },
            { 7055000.0d, 0.000012676d },
            { 7082000.0d, 0.0000120638d },
            { 7109000.0d, 0.0000114662d },
            { 7136000.0d, 0.0000108827d },
            { 7163000.0d, 0.0000103125d },
            { 7190000.0d, 0.00000975575d },
            { 7217000.0d, 0.00000921298d },
            { 7244000.0d, 0.00000868462d },
            { 7271000.0d, 0.00000817113d },
            { 7298000.0d, 0.00000767297d },
            { 7325000.0d, 0.00000719037d },
            { 7352000.0d, 0.00000672287d },
            { 7379000.0d, 0.00000627074d },
            { 7406000.0d, 0.00000583442d },
            { 7433000.0d, 0.00000541435d },
            { 7460000.0d, 0.00000501095d },
            { 7487000.0d, 0.0000046245d },
            { 7514000.0d, 0.0000042547d },
            { 7541000.0d, 0.00000390052d },
            { 7568000.0d, 0.00000356109d },
            { 7595000.0d, 0.00000323657d },
            { 7622000.0d, 0.00000292649d },
            { 7649000.0d, 0.00000263061d },
            { 7676000.0d, 0.00000234903d },
            { 7703000.0d, 0.00000208203d },
            { 7730000.0d, 0.00000182992d },
            { 7757000.0d, 0.00000159308d },
            { 7784000.0d, 0.00000137185d },
            { 7811000.0d, 0.00000116657d },
            { 7838000.0d, 0.000000977598d },
            { 7865000.0d, 0.000000805035d },
            { 7892000.0d, 0.000000648632d },
            { 7919000.0d, 0.000000508689d },
            { 7946000.0d, 0.000000385508d },
            { 7973000.0d, 0.000000279396d },
            { 8000000.0d, 0.000000190647d },
            { 8027000.0d, 0.000000119025d },
            { 8054000.0d, 0.0000000640119d },
            { 8081000.0d, 0.0000000258244d },
            { 8108000.0d, 0.00000000465161d },
            { 8128000.0d, 0d },

        }; 
    }
}
    