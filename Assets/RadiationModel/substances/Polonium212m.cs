using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium212m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium212m";
        public override double halfLife { get; } = 45.1d;
        public override double atomicWeight { get; } = 211.99201d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9993000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead208()), new(1.0d, new AlphaParticle(12899502.09)), new(0.02d, new GammaParticle(570000.0, 0.00218)), new(0.026000000000000002d, new GammaParticle(2610000.0, 0.00048)) } },
            { 0.0007000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium212()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    