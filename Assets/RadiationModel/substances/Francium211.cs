using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium211 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium211";
        public override double halfLife { get; } = 186.0d;
        public override double atomicWeight { get; } = 210.99556d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.8d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine207()), new(1.0d, new AlphaParticle(7684002.09)) } },
            { 0.2d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon211()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    