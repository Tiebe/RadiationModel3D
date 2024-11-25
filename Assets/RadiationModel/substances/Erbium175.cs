using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium175";
        public override double halfLife { get; } = 72.0d;
        public override double atomicWeight { get; } = 174.94777d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium175() }, { 1.0d, new BetaParticle(-1, 1830000.0) }, { 0.3104d, new GammaParticle(120900.0, 0.01026) }, { 0.1024d, new GammaParticle(227300.0, 0.00545) }, { 0.32d, new GammaParticle(234000.0, 0.0053) }, { 0.16d, new GammaParticle(281400.0, 0.00441) }, { 0.48d, new GammaParticle(1167500.0, 0.00106) }, { 0.122995232032d, new GammaParticle(8215.0, 0.15092) }, { 0.14655462405527964d, new GammaParticle(49773.0, 0.02491) }, { 0.2587475707190672d, new GammaParticle(50742.0, 0.02443) }, { 0.08459879144893112d, new GammaParticle(57612.0, 0.02152) }, { 0.10659447722565321d, new GammaParticle(58257.0, 0.02128) }, { 0.02199568577672209d, new GammaParticle(59034.0, 0.021) } } },

        };
    }
}
    