using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium213 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium213";
        public override double halfLife { get; } = 0.0053d;
        public override double atomicWeight { get; } = 213.0211d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium209()), new(1.0d, new AlphaParticle(9407002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    