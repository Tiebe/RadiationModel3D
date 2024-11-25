using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium80";
        public override double halfLife { get; } = 33.4d;
        public override double atomicWeight { get; } = 79.92252d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bromine80() }, { 1.0d, new BetaParticle(1, 1856750.0) }, { 0.25d, new GammaParticle(616700.0, 0.00201) }, { 0.015d, new GammaParticle(639600.0, 0.00194) }, { 0.01875d, new GammaParticle(704300.0, 0.00176) }, { 0.00575d, new GammaParticle(1257100.0, 0.00099) }, { 1.96d, new GammaParticle(511000.0, 0.00243) }, { 0.00038072691275d, new GammaParticle(1648.0, 0.75233) }, { 0.0026571081632263075d, new GammaParticle(12596.0, 0.09843) }, { 0.005123617746290605d, new GammaParticle(12649.0, 0.09802) }, { 0.0012277544426626886d, new GammaParticle(14169.0, 0.0875) }, { 0.0013515120904830876d, new GammaParticle(14209.0, 0.08726) }, { 0.00012375764782039902d, new GammaParticle(14313.0, 0.08662) } } },

        };
    }
}
    