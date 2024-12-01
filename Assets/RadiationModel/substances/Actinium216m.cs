using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium216m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium216m";
        public override double halfLife { get; } = 0.00044d;
        public override double atomicWeight { get; } = 216.00879d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium212()), new(1.0d, new AlphaParticle(10301002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    