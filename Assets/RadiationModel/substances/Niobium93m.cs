using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium93m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium93m";
        public override double halfLife { get; } = 508697646.71042d;
        public override double atomicWeight { get; } = 92.90641d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium93()), new(5.91e-06d, new GammaParticle(30770.0, 0.04029)), new(0.029125080997d, new GammaParticle(2299.0, 0.5393)), new(0.03292296029449552d, new GammaParticle(16521.0, 0.07505)), new(0.06287807542875386d, new GammaParticle(16615.0, 0.07462)), new(0.016269515023261398d, new GammaParticle(18694.0, 0.06632)), new(0.018709942276750605d, new GammaParticle(18795.0, 0.06597)), new(0.0024404272534892094d, new GammaParticle(18951.0, 0.06542)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    