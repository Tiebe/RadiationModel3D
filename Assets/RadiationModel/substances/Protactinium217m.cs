using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium217m : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium217m";
        public override double halfLife { get; } = 0.00108d;
        public override double atomicWeight { get; } = 217.02031d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.73d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium213()), new(1.0d, new AlphaParticle(11371002.09)) } },
            { 0.27d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium217()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    