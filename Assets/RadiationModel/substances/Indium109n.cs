using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium109n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium109n";
        public override double halfLife { get; } = 0.21d;
        public override double atomicWeight { get; } = 108.90941d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium109()), new(0.12d, new GammaParticle(170000.0, 0.00729)), new(0.12d, new GammaParticle(210000.0, 0.0059)), new(0.183d, new GammaParticle(401970.0, 0.00308)), new(0.976d, new GammaParticle(673520.0, 0.00184)), new(0.185d, new GammaParticle(1026400.0, 0.00121)), new(0.815d, new GammaParticle(1428320.0, 0.00087)), new(0.001737118523376d, new GammaParticle(3571.0, 0.3472)), new(0.005706831333523383d, new GammaParticle(24001.0, 0.05166)), new(0.010707000625747436d, new GammaParticle(24209.0, 0.05121)), new(0.0030041450426295663d, new GammaParticle(27367.0, 0.0453)), new(0.0035749326007291837d, new GammaParticle(27581.0, 0.04495)), new(0.0005707875580996175d, new GammaParticle(27858.0, 0.04451)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    