using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium47 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium47";
        public override double halfLife { get; } = 1956.0d;
        public override double atomicWeight { get; } = 46.9549d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium47() }, { 1.0d, new BetaParticle(1, 1164865.0) }, { 0.00106769d, new GammaParticle(159800.0, 0.00776) }, { 0.0009378100000000001d, new GammaParticle(244400.0, 0.00507) }, { 2.483e-05d, new GammaParticle(1243500.0, 0.001) }, { 0.00079265d, new GammaParticle(1390400.0, 0.00089) }, { 0.00066468d, new GammaParticle(1549900.0, 0.0008) }, { 0.00191d, new GammaParticle(1793900.0, 0.00069) }, { 3.629e-05d, new GammaParticle(2003100.0, 0.00062) }, { 9.932e-05d, new GammaParticle(2007300.0, 0.00062) }, { 0.0006704100000000001d, new GammaParticle(2163000.0, 0.00057) }, { 8.404e-05d, new GammaParticle(2366300.0, 0.00052) }, { 8.786e-05d, new GammaParticle(2525600.0, 0.00049) }, { 6.685e-05d, new GammaParticle(2548700.0, 0.00049) }, { 6.493999999999999e-06d, new GammaParticle(2793300.0, 0.00044) }, { 1.93091598d, new GammaParticle(511000.0, 0.00243) }, { 0.00016493838939274317d, new GammaParticle(477.0, 2.59925) }, { 0.0020701026678480615d, new GammaParticle(4505.0, 0.27521) }, { 0.004078216445721161d, new GammaParticle(4511.0, 0.27485) }, { 0.000814652282547922d, new GammaParticle(4947.0, 0.25063) }, { 0.000814652282547922d, new GammaParticle(4947.0, 0.25063) } } },

        };
    }
}
    