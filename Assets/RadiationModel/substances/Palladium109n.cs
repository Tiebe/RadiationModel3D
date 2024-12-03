using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium109n : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium109n";
        public override double halfLife { get; } = 282.18d;
        public override double atomicWeight { get; } = 108.90615d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium109()), new(0.56d, new GammaParticle(188900.0, 0.00656)), new(0.0219537024d, new GammaParticle(3053.0, 0.40611)), new(0.0751376550074929d, new GammaParticle(21020.0, 0.05898)), new(0.14195665030699586d, new GammaParticle(21177.0, 0.05855)), new(0.0389470894747959d, new GammaParticle(23904.0, 0.05187)), new(0.0455680946855112d, new GammaParticle(24070.0, 0.05151)), new(0.006621005210715303d, new GammaParticle(24297.0, 0.05103)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    