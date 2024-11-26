using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium164m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium164m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 163.93709d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium164() }, { 0.10220000000000001d, new GammaParticle(60200.0, 0.0206) }, { 0.1387d, new GammaParticle(73000.0, 0.01698) }, { 0.5183d, new GammaParticle(168400.0, 0.00736) }, { 0.73d, new GammaParticle(854700.0, 0.00145) }, { 0.2701d, new GammaParticle(961900.0, 0.00129) }, { 0.2072867643264d, new GammaParticle(6858.0, 0.18079) }, { 0.14958621682120163d, new GammaParticle(42308.0, 0.02931) }, { 0.2690883554977543d, new GammaParticle(42996.0, 0.02884) }, { 0.08506088302220435d, new GammaParticle(48802.0, 0.02541) }, { 0.1074318952570441d, new GammaParticle(49326.0, 0.02514) }, { 0.022371012234839744d, new GammaParticle(49957.0, 0.02482) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    