using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neodymium134m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium134m";
        public override double halfLife { get; } = 0.00041d;
        public override double atomicWeight { get; } = 133.92125d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium134()), new(0.9d, new GammaParticle(166500.0, 0.00745)), new(0.9470000000000001d, new GammaParticle(294200.0, 0.00421)), new(0.98804d, new GammaParticle(494700.0, 0.00251)), new(0.99354d, new GammaParticle(631100.0, 0.00196)), new(0.9951000000000001d, new GammaParticle(707500.0, 0.00175)), new(0.063d, new GammaParticle(874000.0, 0.00142)), new(0.016117772048000002d, new GammaParticle(5870.0, 0.21122)), new(0.028995938259958325d, new GammaParticle(36848.0, 0.03365)), new(0.05280629805128087d, new GammaParticle(37362.0, 0.03318)), new(0.01621727707936421d, new GammaParticle(42380.0, 0.02926)), new(0.02038511728876081d, new GammaParticle(42810.0, 0.02896)), new(0.004167840209396602d, new GammaParticle(43335.0, 0.02861)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    