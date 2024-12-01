using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium157n : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium157n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 156.92443d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium157()), new(0.01125d, new GammaParticle(9000.0, 0.13776)), new(0.038d, new GammaParticle(51000.0, 0.02431)), new(0.050300000000000004d, new GammaParticle(55000.0, 0.02254)), new(0.175d, new GammaParticle(64000.0, 0.01937)), new(0.06875d, new GammaParticle(65000.0, 0.01907)), new(0.075d, new GammaParticle(76000.0, 0.01631)), new(0.09375d, new GammaParticle(95000.0, 0.01305)), new(0.0125d, new GammaParticle(116000.0, 0.01069)), new(0.00625d, new GammaParticle(131000.0, 0.00946)), new(0.06875d, new GammaParticle(171000.0, 0.00725)), new(0.3d, new GammaParticle(199000.0, 0.00623)), new(0.60625d, new GammaParticle(245000.0, 0.00506)), new(0.3766825535d, new GammaParticle(6858.0, 0.18079)), new(0.4782698554804358d, new GammaParticle(42308.0, 0.02931)), new(0.8603523214255007d, new GammaParticle(42996.0, 0.02884)), new(0.2719639355455767d, new GammaParticle(48802.0, 0.02541)), new(0.34349045059406336d, new GammaParticle(49326.0, 0.02514)), new(0.07152651504848667d, new GammaParticle(49957.0, 0.02482)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    