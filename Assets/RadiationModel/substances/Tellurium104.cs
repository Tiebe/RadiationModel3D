using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium104";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 103.94672d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin100()), new(1.0d, new AlphaParticle(6117002.09)) } },
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
    