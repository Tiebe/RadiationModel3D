using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium215";
        public override double halfLife { get; } = 0.0007d;
        public override double atomicWeight { get; } = 215.02672d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium211()), new(1.0d, new AlphaParticle(9607002.09)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    