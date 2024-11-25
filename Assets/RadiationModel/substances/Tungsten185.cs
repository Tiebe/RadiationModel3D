using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten185 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten185";
        public override double halfLife { get; } = 6488640.0d;
        public override double atomicWeight { get; } = 184.95342d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium185() }, { 1.0d, new BetaParticle(-1, 215550.0) }, { 0.00019199999999999998d, new GammaParticle(125358.0, 0.00989) }, { 0.0001272689472d, new GammaParticle(10063.0, 0.12321) }, { 0.00011961131276086376d, new GammaParticle(59718.0, 0.02076) }, { 0.00020693998747554283d, new GammaParticle(61141.0, 0.02028) }, { 6.8788018608922e-05d, new GammaParticle(69395.0, 0.01787) }, { 8.784229976359339e-05d, new GammaParticle(70206.0, 0.01766) }, { 1.9054281154671394e-05d, new GammaParticle(71195.0, 0.01741) } } },

        };
    }
}
    