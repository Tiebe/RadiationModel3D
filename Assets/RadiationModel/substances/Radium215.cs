using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium215";
        public override double halfLife { get; } = 0.00166d;
        public override double atomicWeight { get; } = 215.00272d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon211()), new(1.0d, new AlphaParticle(9884002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    