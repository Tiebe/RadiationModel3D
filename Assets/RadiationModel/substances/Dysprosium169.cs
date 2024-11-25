using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium169";
        public override double halfLife { get; } = 39.0d;
        public override double atomicWeight { get; } = 168.94031d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium169() }, { 1.0d, new BetaParticle(-1, 1598000.0) }, { 0.2d, new GammaParticle(1578200.0, 0.00079) }, { 5.6336880000000005e-05d, new GammaParticle(7656.0, 0.16194) }, { 7.507267727414396e-05d, new GammaParticle(46700.0, 0.02655) }, { 0.00013370022666811033d, new GammaParticle(47547.0, 0.02608) }, { 4.319610798233785e-05d, new GammaParticle(53982.0, 0.02297) }, { 5.44270960577457e-05d, new GammaParticle(54577.0, 0.02272) }, { 1.1230988075407842e-05d, new GammaParticle(55293.0, 0.02242) } } },

        };
    }
}
    