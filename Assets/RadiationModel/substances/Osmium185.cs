using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium185 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium185";
        public override double halfLife { get; } = 8087040.0d;
        public override double atomicWeight { get; } = 184.95405d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium185()), new(0.002652d, new GammaParticle(71313.0, 0.01739)), new(0.000234d, new GammaParticle(121200.0, 0.01023)), new(0.0034164d, new GammaParticle(125358.1, 0.00989)), new(0.0056628d, new GammaParticle(162852.0, 0.00761)), new(0.0041262d, new GammaParticle(234157.0, 0.00529)), new(0.013182000000000001d, new GammaParticle(592074.0, 0.00209)), new(0.78d, new GammaParticle(646116.0, 0.00192)), new(0.03939d, new GammaParticle(717424.0, 0.00173)), new(3.12e-05d, new GammaParticle(749460.0, 0.00165)), new(3.51e-05d, new GammaParticle(768930.0, 0.00161)), new(3.8999999999999997e-07d, new GammaParticle(805700.0, 0.00154)), new(0.062946d, new GammaParticle(874813.0, 0.00142)), new(0.051714d, new GammaParticle(880523.0, 0.00141)), new(0.0004836d, new GammaParticle(931057.0, 0.00133)), new(0.2356282132070226d, new GammaParticle(10063.0, 0.12321)), new(0.20058086516961862d, new GammaParticle(59718.0, 0.02076)), new(0.3470257182865374d, new GammaParticle(61141.0, 0.02028)), new(0.11535330536390445d, new GammaParticle(69395.0, 0.01787)), new(0.14730617094970597d, new GammaParticle(70206.0, 0.01766)), new(0.03195286558580153d, new GammaParticle(71195.0, 0.01741)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    