using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum162 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum162";
        public override double halfLife { get; } = 3.57d;
        public override double atomicWeight { get; } = 161.95729d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99926d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium162()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.00074d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium158()), new(1.0d, new AlphaParticle(6029002.09)) } },
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
    