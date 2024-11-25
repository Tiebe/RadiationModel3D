using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium133";
        public override double halfLife { get; } = 5820.0d;
        public override double atomicWeight { get; } = 132.91152d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium133() }, { 1.0d, new BetaParticle(1, 2567750.0) }, { 0.15925d, new GammaParticle(76900.0, 0.01612) }, { 0.455d, new GammaParticle(97261.0, 0.01275) }, { 0.004095d, new GammaParticle(174000.0, 0.00713) }, { 0.0091d, new GammaParticle(376700.0, 0.00329) }, { 0.11375d, new GammaParticle(557700.0, 0.00222) }, { 0.74d, new GammaParticle(511000.0, 0.00243) }, { 0.1607077395495d, new GammaParticle(5185.0, 0.23912) }, { 0.34629037457875955d, new GammaParticle(33034.0, 0.03753) }, { 0.6360954713055833d, new GammaParticle(33442.0, 0.03707) }, { 0.1894209260699579d, new GammaParticle(37908.0, 0.03271) }, { 0.2373444203656572d, new GammaParticle(38273.0, 0.03239) }, { 0.04792349429569935d, new GammaParticle(38725.0, 0.03202) } } },

        };
    }
}
    