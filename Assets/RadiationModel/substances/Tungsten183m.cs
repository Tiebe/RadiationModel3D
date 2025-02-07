using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten183m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten183m";
        public override double halfLife { get; } = 5.3d;
        public override double atomicWeight { get; } = 182.95056d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten183()), new(0.0613d, new GammaParticle(46483.8, 0.02667)), new(0.0676d, new GammaParticle(52595.2, 0.02357)), new(0.0814d, new GammaParticle(99079.3, 0.01251)), new(0.024d, new GammaParticle(101481.0, 0.01222)), new(0.18899999999999997d, new GammaParticle(107931.0, 0.01149)), new(0.0512d, new GammaParticle(160526.0, 0.00772)), new(0.6681640881350001d, new GammaParticle(9740.0, 0.12729)), new(0.3644164085033761d, new GammaParticle(57983.0, 0.02138)), new(0.632997061843627d, new GammaParticle(59320.0, 0.0209)), new(0.20981696236498965d, new GammaParticle(67335.0, 0.01841)), new(0.26730681005299683d, new GammaParticle(68117.0, 0.0182)), new(0.05748984768800716d, new GammaParticle(69068.0, 0.01795)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    