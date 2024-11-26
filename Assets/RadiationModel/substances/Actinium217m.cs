using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium217m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium217m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 217.0115d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9549d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium217() }, { 0.0040999999999999995d, new GammaParticle(30300.0, 0.04092) }, { 0.05d, new GammaParticle(96000.0, 0.01292) }, { 0.07d, new GammaParticle(110000.0, 0.01127) }, { 0.16d, new GammaParticle(153800.0, 0.00806) }, { 0.1d, new GammaParticle(220000.0, 0.00564) }, { 0.05d, new GammaParticle(234000.0, 0.0053) }, { 0.16d, new GammaParticle(349000.0, 0.00355) }, { 0.21d, new GammaParticle(351500.0, 0.00353) }, { 0.46d, new GammaParticle(381800.0, 0.00325) }, { 0.08d, new GammaParticle(478900.0, 0.00259) }, { 0.77d, new GammaParticle(486400.0, 0.00255) }, { 0.06d, new GammaParticle(489000.0, 0.00254) }, { 0.83d, new GammaParticle(660300.0, 0.00188) }, { 0.11d, new GammaParticle(670100.0, 0.00185) }, { 1.1417026958271999d, new GammaParticle(15349.0, 0.08078) }, { 0.546808924641621d, new GammaParticle(87674.0, 0.01414) }, { 0.8888311518882007d, new GammaParticle(90886.0, 0.01364) }, { 0.3134067984022342d, new GammaParticle(102818.0, 0.01206) }, { 0.4177712622701782d, new GammaParticle(104107.0, 0.01191) }, { 0.104364463867944d, new GammaParticle(105738.0, 0.01173) } } },
            { 0.0451d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium213() }, { 1.0d, new AlphaParticle(12866002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    