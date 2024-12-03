using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium172m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium172m";
        public override double halfLife { get; } = 222.0d;
        public override double atomicWeight { get; } = 171.93914d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium172()), new(3.9e-05d, new GammaParticle(41860.0, 0.02962)), new(0.178932d, new GammaParticle(8810.0, 0.14073)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    