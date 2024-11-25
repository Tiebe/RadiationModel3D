using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium159m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium159m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 158.93459d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium159() }, { 0.25d, new GammaParticle(163100.0, 0.0076) }, { 0.67d, new GammaParticle(243200.0, 0.0051) }, { 1.0d, new GammaParticle(869600.0, 0.00143) }, { 0.023382275746d, new GammaParticle(6354.0, 0.19513) }, { 0.03297030664938282d, new GammaParticle(39522.0, 0.03137) }, { 0.059674763166303754d, new GammaParticle(40117.0, 0.03091) }, { 0.018654210003428782d, new GammaParticle(45523.0, 0.02724) }, { 0.02346699618431341d, new GammaParticle(45998.0, 0.02695) }, { 0.004812786180884626d, new GammaParticle(46575.0, 0.02662) } } },

        };
    }
}
    