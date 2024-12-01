using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Moscovium290 : RadioactiveSubstance
    {
        public override string name { get; } = "Moscovium290";
        public override double halfLife { get; } = 0.65d;
        public override double atomicWeight { get; } = 290.19623d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nihonium286()), new(1.0d, new AlphaParticle(11427002.09)) } },
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
    