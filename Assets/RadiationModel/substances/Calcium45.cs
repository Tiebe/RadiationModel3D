using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium45 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium45";
        public override double halfLife { get; } = 14049504.0d;
        public override double atomicWeight { get; } = 44.95619d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium45() }, { 1.0d, new BetaParticle(-1, 130050.0) }, { 4.5e-08d, new GammaParticle(12400.0, 0.09999) }, { 7.58132604e-08d, new GammaParticle(422.0, 2.93801) }, { 9.462493309994805e-07d, new GammaParticle(4086.0, 0.30344) }, { 1.866737681987533e-06d, new GammaParticle(4091.0, 0.30307) }, { 3.71032987012987e-07d, new GammaParticle(4474.0, 0.27712) }, { 3.71032987012987e-07d, new GammaParticle(4474.0, 0.27712) } } },

        };
    }
}
    