using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium169m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium169m";
        public override double halfLife { get; } = 160.0d;
        public override double atomicWeight { get; } = 168.93768d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium169()), new(1.06e-05d, new GammaParticle(29000.0, 0.04275)), new(0.17856000000000002d, new GammaParticle(8810.0, 0.14073)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    