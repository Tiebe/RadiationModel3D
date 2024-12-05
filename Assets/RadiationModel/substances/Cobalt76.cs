using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt76 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt76";
        public override double halfLife { get; } = 0.0217d;
        public override double atomicWeight { get; } = 75.97245d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel76()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.8759999999999999d, new GammaParticle(142560.0, 0.0087)), new(0.977d, new GammaParticle(355370.0, 0.00349)), new(1.001d, new GammaParticle(929970.0, 0.00133)), new(1.0170000000000001d, new GammaParticle(990100.0, 0.00125)), new(0.0015136818822081598d, new GammaParticle(874.0, 1.41858)), new(0.015108880942486113d, new GammaParticle(7461.0, 0.16618)), new(0.029486496765195377d, new GammaParticle(7478.0, 0.1658)), new(0.006145243048118509d, new GammaParticle(8296.0, 0.14945)), new(0.006145243048118509d, new GammaParticle(8296.0, 0.14945)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    