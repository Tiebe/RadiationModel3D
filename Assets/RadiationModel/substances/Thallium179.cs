using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium179";
        public override double halfLife { get; } = 0.23d;
        public override double atomicWeight { get; } = 178.99112d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold175()), new(1.0d, new AlphaParticle(7727002.09)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
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
    