using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Europium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium162";
        public override double halfLife { get; } = 11.4d;
        public override double atomicWeight { get; } = 161.93696d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium162()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    