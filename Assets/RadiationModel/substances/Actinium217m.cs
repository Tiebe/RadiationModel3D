using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium217m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium217m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 217.0115d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9549d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium217()), new(0.0040999999999999995d, new GammaParticle(30300.0, 0.04092)), new(0.05d, new GammaParticle(96000.0, 0.01292)), new(0.07d, new GammaParticle(110000.0, 0.01127)), new(0.16d, new GammaParticle(153800.0, 0.00806)), new(0.1d, new GammaParticle(220000.0, 0.00564)), new(0.05d, new GammaParticle(234000.0, 0.0053)), new(0.16d, new GammaParticle(349000.0, 0.00355)), new(0.21d, new GammaParticle(351500.0, 0.00353)), new(0.46d, new GammaParticle(381800.0, 0.00325)), new(0.08d, new GammaParticle(478900.0, 0.00259)), new(0.77d, new GammaParticle(486400.0, 0.00255)), new(0.06d, new GammaParticle(489000.0, 0.00254)), new(0.83d, new GammaParticle(660300.0, 0.00188)), new(0.11d, new GammaParticle(670100.0, 0.00185)), new(1.1417026958271999d, new GammaParticle(15349.0, 0.08078)), new(0.546808924641621d, new GammaParticle(87674.0, 0.01414)), new(0.8888311518882007d, new GammaParticle(90886.0, 0.01364)), new(0.3134067984022342d, new GammaParticle(102818.0, 0.01206)), new(0.4177712622701782d, new GammaParticle(104107.0, 0.01191)), new(0.104364463867944d, new GammaParticle(105738.0, 0.01173)) } },
            { 0.0451d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium213()), new(1.0d, new AlphaParticle(12866002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    