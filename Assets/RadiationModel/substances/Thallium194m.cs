using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium194m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium194m";
        public override double halfLife { get; } = 1968.0d;
        public override double atomicWeight { get; } = 193.97136d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold194()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.077d, new GammaParticle(96900.0, 0.0128)), new(0.0062d, new GammaParticle(98900.0, 0.01254)), new(0.0077d, new GammaParticle(107200.0, 0.01157)), new(0.064d, new GammaParticle(110960.0, 0.01117)), new(0.062d, new GammaParticle(208900.0, 0.00594)), new(0.01d, new GammaParticle(219000.0, 0.00566)), new(0.066d, new GammaParticle(227980.0, 0.00544)), new(0.021d, new GammaParticle(233100.0, 0.00532)), new(0.009300000000000001d, new GammaParticle(239000.0, 0.00519)), new(0.09300000000000001d, new GammaParticle(255400.0, 0.00485)), new(0.019d, new GammaParticle(284000.0, 0.00437)), new(0.021d, new GammaParticle(298100.0, 0.00416)), new(0.01d, new GammaParticle(299500.0, 0.00414)), new(0.039d, new GammaParticle(319800.0, 0.00388)), new(0.017d, new GammaParticle(352200.0, 0.00352)), new(0.018000000000000002d, new GammaParticle(366500.0, 0.00338)), new(0.0139d, new GammaParticle(380500.0, 0.00326)), new(1.0d, new GammaParticle(428200.0, 0.0029)), new(0.028999999999999998d, new GammaParticle(446500.0, 0.00278)), new(0.05d, new GammaParticle(451000.0, 0.00275)), new(0.046d, new GammaParticle(462500.0, 0.00268)), new(0.023d, new GammaParticle(464500.0, 0.00267)), new(0.085d, new GammaParticle(510900.0, 0.00243)), new(0.046d, new GammaParticle(553200.0, 0.00224)), new(0.017d, new GammaParticle(600500.0, 0.00206)), new(1.0d, new GammaParticle(636300.0, 0.00195)), new(0.069d, new GammaParticle(650300.0, 0.00191)), new(0.012d, new GammaParticle(664200.0, 0.00187)), new(0.0077d, new GammaParticle(675700.0, 0.00183)), new(0.0054d, new GammaParticle(682700.0, 0.00182)), new(0.0069d, new GammaParticle(691000.0, 0.00179)), new(0.01d, new GammaParticle(694800.0, 0.00178)), new(0.0123d, new GammaParticle(702200.0, 0.00177)), new(0.0131d, new GammaParticle(711000.0, 0.00174)), new(0.0139d, new GammaParticle(719800.0, 0.00172)), new(0.22d, new GammaParticle(735000.0, 0.00169)), new(0.77d, new GammaParticle(749000.0, 0.00166)), new(0.0069d, new GammaParticle(1383000.0, 0.0009)), new(0.0062d, new GammaParticle(1424400.0, 0.00087)), new(0.0054d, new GammaParticle(1445900.0, 0.00086)), new(0.01d, new GammaParticle(1530700.0, 0.00081)), new(0.0177d, new GammaParticle(1550300.0, 0.0008)), new(0.0069d, new GammaParticle(1640000.0, 0.00076)), new(0.0046d, new GammaParticle(1676000.0, 0.00074)), new(0.01d, new GammaParticle(1691400.0, 0.00073)), new(0.0054d, new GammaParticle(1822000.0, 0.00068)), new(0.0046d, new GammaParticle(1832000.0, 0.00068)), new(0.0069d, new GammaParticle(1936000.0, 0.00064)), new(0.307d, new GammaParticle(511000.0, 0.00243)), new(0.47d, new GammaParticle(11777.0, 0.10528)), new(0.27d, new GammaParticle(68894.0, 0.018)), new(0.47d, new GammaParticle(70820.0, 0.01751)), new(0.158d, new GammaParticle(80316.0, 0.01544)), new(0.204d, new GammaParticle(81285.0, 0.01525)), new(0.046d, new GammaParticle(82477.0, 0.01503)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    