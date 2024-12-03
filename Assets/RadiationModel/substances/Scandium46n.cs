using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Scandium46n : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium46n";
        public override double halfLife { get; } = 18.75d;
        public override double atomicWeight { get; } = 45.95532d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Scandium46()), new(0.62d, new GammaParticle(142528.0, 0.0087)), new(0.0015188120656d, new GammaParticle(422.0, 2.93801)), new(0.019465534098701533d, new GammaParticle(4086.0, 0.30344)), new(0.03840113256796515d, new GammaParticle(4091.0, 0.30307)), new(0.007632613333333335d, new GammaParticle(4474.0, 0.27712)), new(0.007632613333333335d, new GammaParticle(4474.0, 0.27712)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    