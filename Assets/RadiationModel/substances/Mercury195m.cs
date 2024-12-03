using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury195m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury195m";
        public override double halfLife { get; } = 149760.0d;
        public override double atomicWeight { get; } = 194.9669d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.542d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury195()), new(0.00167d, new GammaParticle(16207.0, 0.0765)), new(0.019299999999999998d, new GammaParticle(37090.0, 0.03343)), new(9.499999999999999e-05d, new GammaParticle(53290.0, 0.02327)), new(0.000294d, new GammaParticle(122780.0, 0.0101)), new(0.419776212633d, new GammaParticle(11777.0, 0.10528)), new(0.013100747935468822d, new GammaParticle(68894.0, 0.018)), new(0.022208421657007666d, new GammaParticle(70820.0, 0.01751)), new(0.0075369921171875584d, new GammaParticle(80316.0, 0.01544)), new(0.009745330807523512d, new GammaParticle(81285.0, 0.01525)), new(0.002208338690335955d, new GammaParticle(82477.0, 0.01503)) } },
            { 0.45799999999999996d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum195()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.000128d, new GammaParticle(56800.0, 0.02183)), new(0.00086d, new GammaParticle(61460.0, 0.02017)), new(6.4000000000000006e-06d, new GammaParticle(90420.0, 0.01371)), new(0.00054d, new GammaParticle(172310.0, 0.0072)), new(0.008d, new GammaParticle(200380.0, 0.00619)), new(0.0037d, new GammaParticle(207100.0, 0.00599)), new(0.31d, new GammaParticle(261750.0, 0.00474)), new(0.0014000000000000002d, new GammaParticle(279250.0, 0.00444)), new(8e-05d, new GammaParticle(287400.0, 0.00431)), new(6e-05d, new GammaParticle(308500.0, 0.00402)), new(0.000178d, new GammaParticle(318600.0, 0.00389)), new(8e-05d, new GammaParticle(324550.0, 0.00382)), new(0.00032d, new GammaParticle(338170.0, 0.00367)), new(0.0034000000000000002d, new GammaParticle(368550.0, 0.00336)), new(0.0028000000000000004d, new GammaParticle(386400.0, 0.00321)), new(0.0218d, new GammaParticle(387870.0, 0.0032)), new(0.00015d, new GammaParticle(401920.0, 0.00308)), new(0.00062d, new GammaParticle(419000.0, 0.00296)), new(0.00037d, new GammaParticle(441500.0, 0.00281)), new(0.00207d, new GammaParticle(452040.0, 0.00274)), new(4.3e-05d, new GammaParticle(462130.0, 0.00268)), new(0.0029d, new GammaParticle(467360.0, 0.00265)), new(0.00027d, new GammaParticle(518450.0, 0.00239)), new(0.005d, new GammaParticle(525750.0, 0.00236)), new(9e-06d, new GammaParticle(531720.0, 0.00233)), new(1.9e-05d, new GammaParticle(540320.0, 0.00229)), new(0.00015d, new GammaParticle(542400.0, 0.00229)), new(0.0005d, new GammaParticle(549400.0, 0.00226)), new(0.00045d, new GammaParticle(556640.0, 0.00223)), new(0.071d, new GammaParticle(560270.0, 0.00221)), new(0.0021d, new GammaParticle(575520.0, 0.00215)), new(0.00032d, new GammaParticle(578020.0, 0.00214)), new(8.999999999999999e-05d, new GammaParticle(628300.0, 0.00197)), new(5.7e-05d, new GammaParticle(637800.0, 0.00194)), new(5.7e-05d, new GammaParticle(658700.0, 0.00188)), new(0.00055d, new GammaParticle(665420.0, 0.00186)), new(0.0022d, new GammaParticle(680680.0, 0.00182)), new(0.00043999999999999996d, new GammaParticle(693170.0, 0.00179)), new(0.00065d, new GammaParticle(698060.0, 0.00178)), new(8e-05d, new GammaParticle(701100.0, 0.00177)), new(3.5000000000000004e-05d, new GammaParticle(703400.0, 0.00176)), new(2.3e-05d, new GammaParticle(710900.0, 0.00174)), new(9e-06d, new GammaParticle(720800.0, 0.00172)), new(0.00048d, new GammaParticle(727200.0, 0.0017)), new(0.00027d, new GammaParticle(749500.0, 0.00165)), new(0.0005600000000000001d, new GammaParticle(754860.0, 0.00164)), new(0.00016d, new GammaParticle(792000.0, 0.00157)), new(0.00021999999999999998d, new GammaParticle(847400.0, 0.00146)), new(0.0027d, new GammaParticle(853050.0, 0.00145)), new(0.0001d, new GammaParticle(897300.0, 0.00138)), new(0.0004d, new GammaParticle(899500.0, 0.00138)), new(6e-05d, new GammaParticle(946300.0, 0.00131)), new(0.00214d, new GammaParticle(961920.0, 0.00129)), new(0.00116d, new GammaParticle(1027450.0, 0.00121)), new(1.8e-05d, new GammaParticle(1040600.0, 0.00119)), new(0.00048d, new GammaParticle(1086200.0, 0.00114)), new(0.0063d, new GammaParticle(1241170.0, 0.001)), new(6.5e-05d, new GammaParticle(1286400.0, 0.00096)), new(0.00021999999999999998d, new GammaParticle(511000.0, 0.00243)), new(0.26943439592799634d, new GammaParticle(11419.0, 0.10858)), new(0.1283419929493518d, new GammaParticle(66991.0, 0.01851)), new(0.21849164615143313d, new GammaParticle(68806.0, 0.01802)), new(0.07372569209745156d, new GammaParticle(78048.0, 0.01589)), new(0.09503241711361506d, new GammaParticle(78983.0, 0.0157)), new(0.0213067250161635d, new GammaParticle(80133.0, 0.01547)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    