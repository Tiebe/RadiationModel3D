using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium213 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium213";
        public override double halfLife { get; } = 0.146d;
        public override double atomicWeight { get; } = 213.01301d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium209()), new(1.0d, new AlphaParticle(8859002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    