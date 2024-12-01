using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium222 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium222";
        public override double halfLife { get; } = 0.00196d;
        public override double atomicWeight { get; } = 222.01847d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium218()), new(1.0d, new AlphaParticle(9154002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    