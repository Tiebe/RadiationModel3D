using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Beryllium7 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium7";
        public override double halfLife { get; } = 4598208.0d;
        public override double atomicWeight { get; } = 7.01693d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lithium7()), new(0.10439999999999999d, new GammaParticle(477603.5, 0.0026)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    