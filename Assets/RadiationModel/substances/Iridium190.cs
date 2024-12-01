using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium190 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium190";
        public override double halfLife { get; } = 1017792.0d;
        public override double atomicWeight { get; } = 189.96054d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium190()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0009071999999999999d, new GammaParticle(97930.0, 0.01266)), new(0.4968d, new GammaParticle(186680.0, 0.00664)), new(0.0012744d, new GammaParticle(190520.0, 0.00651)), new(0.032400000000000005d, new GammaParticle(196850.0, 0.0063)), new(0.01836d, new GammaParticle(198080.0, 0.00626)), new(0.00216d, new GammaParticle(199300.0, 0.00622)), new(0.011231999999999999d, new GammaParticle(207910.0, 0.00596)), new(0.0032400000000000003d, new GammaParticle(207910.0, 0.00596)), new(0.035424000000000004d, new GammaParticle(223810.0, 0.00554)), new(0.0040176d, new GammaParticle(235500.0, 0.00526)), new(0.0011448d, new GammaParticle(248200.0, 0.005)), new(0.004536d, new GammaParticle(282930.0, 0.00438)), new(0.015552d, new GammaParticle(288220.0, 0.0043)), new(0.06264d, new GammaParticle(294750.0, 0.00421)), new(0.123336d, new GammaParticle(361090.0, 0.00343)), new(0.21600000000000003d, new GammaParticle(371240.0, 0.00334)), new(0.019224d, new GammaParticle(380030.0, 0.00326)), new(0.0004104d, new GammaParticle(394500.0, 0.00314)), new(0.061992000000000005d, new GammaParticle(397360.0, 0.00312)), new(0.0432d, new GammaParticle(407220.0, 0.00304)), new(0.2268d, new GammaParticle(407220.0, 0.00304)), new(0.015552d, new GammaParticle(420630.0, 0.00295)), new(0.0002376d, new GammaParticle(426200.0, 0.00291)), new(0.025920000000000002d, new GammaParticle(431620.0, 0.00287)), new(0.024192d, new GammaParticle(447810.0, 0.00277)), new(0.01728d, new GammaParticle(477800.0, 0.00259)), new(0.006912000000000001d, new GammaParticle(485230.0, 0.00256)), new(0.0073872d, new GammaParticle(490760.0, 0.00253)), new(0.01188d, new GammaParticle(502550.0, 0.00247)), new(0.32183999999999996d, new GammaParticle(518550.0, 0.00239)), new(0.28512d, new GammaParticle(557950.0, 0.00222)), new(0.27d, new GammaParticle(569300.0, 0.00218)), new(0.37799999999999995d, new GammaParticle(605140.0, 0.00205)), new(0.004449600000000001d, new GammaParticle(615390.0, 0.00201)), new(0.007128d, new GammaParticle(628400.0, 0.00197)), new(0.027864d, new GammaParticle(630910.0, 0.00197)), new(0.007992d, new GammaParticle(631000.0, 0.00196)), new(0.011016d, new GammaParticle(656020.0, 0.00189)), new(0.0004968d, new GammaParticle(668100.0, 0.00186)), new(0.0026784d, new GammaParticle(690040.0, 0.0018)), new(0.0006912d, new GammaParticle(709100.0, 0.00175)), new(0.035856d, new GammaParticle(726220.0, 0.00171)), new(0.0003456d, new GammaParticle(731100.0, 0.0017)), new(0.0018360000000000002d, new GammaParticle(740190.0, 0.00168)), new(0.0002376d, new GammaParticle(753000.0, 0.00165)), new(0.020952000000000002d, new GammaParticle(768570.0, 0.00161)), new(0.0030672d, new GammaParticle(821780.0, 0.00151)), new(0.0054d, new GammaParticle(828000.0, 0.0015)), new(0.032832d, new GammaParticle(828990.0, 0.0015)), new(0.0108d, new GammaParticle(839140.0, 0.00148)), new(0.001188d, new GammaParticle(916750.0, 0.00135)), new(0.0006479999999999999d, new GammaParticle(948000.0, 0.00131)), new(0.0009288d, new GammaParticle(952300.0, 0.0013)), new(0.00054d, new GammaParticle(976400.0, 0.00127)), new(0.022896d, new GammaParticle(1036050.0, 0.0012)), new(0.0003024d, new GammaParticle(1123800.0, 0.0011)), new(0.0040608d, new GammaParticle(1133770.0, 0.00109)), new(0.0012528d, new GammaParticle(1147300.0, 0.00108)), new(0.00032399999999999996d, new GammaParticle(1150700.0, 0.00108)), new(0.0002808d, new GammaParticle(1160400.0, 0.00107)), new(0.004168799999999999d, new GammaParticle(1200240.0, 0.00103)), new(0.004536d, new GammaParticle(1324300.0, 0.00094)), new(0.0006479999999999999d, new GammaParticle(1355600.0, 0.00091)), new(0.0014688000000000001d, new GammaParticle(1386950.0, 0.00089)), new(0.0014256d, new GammaParticle(1397240.0, 0.00089)), new(0.0005832d, new GammaParticle(1494900.0, 0.00083)), new(0.0006d, new GammaParticle(511000.0, 0.00243)), new(0.3213145803828216d, new GammaParticle(10393.0, 0.1193)), new(0.24988337763544827d, new GammaParticle(61486.0, 0.02016)), new(0.4306106800541932d, new GammaParticle(63000.0, 0.01968)), new(0.14407335127647877d, new GammaParticle(71496.0, 0.01734)), new(0.18441388963389282d, new GammaParticle(72338.0, 0.01714)), new(0.04034053835741406d, new GammaParticle(73364.0, 0.0169)) } },
            { 2e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium190()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    