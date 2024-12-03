using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium171m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium171m";
        public override double halfLife { get; } = 79.0d;
        public override double atomicWeight { get; } = 170.93799d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium171()), new(0.0021d, new GammaParticle(71100.0, 0.01744)), new(0.18470227304d, new GammaParticle(8810.0, 0.14073)), new(0.0009063662697307348d, new GammaParticle(52965.0, 0.02341)), new(0.001591791833036064d, new GammaParticle(54070.0, 0.02293)), new(0.0005237435895832292d, new GammaParticle(61387.0, 0.0202)), new(0.0006620118972332016d, new GammaParticle(62084.0, 0.01997)), new(0.00013826830764997249d, new GammaParticle(62927.0, 0.0197)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    