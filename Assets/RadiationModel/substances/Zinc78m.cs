using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc78m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc78m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 77.94116d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc78() }, { 0.9d, new GammaParticle(144700.0, 0.00857) }, { 1.0d, new GammaParticle(729600.0, 0.0017) }, { 0.96d, new GammaParticle(889900.0, 0.00139) }, { 1.02d, new GammaParticle(908300.0, 0.00137) }, { 0.00201343968d, new GammaParticle(1035.0, 1.19791) }, { 0.018734327164291093d, new GammaParticle(8616.0, 0.1439) }, { 0.03643393069679326d, new GammaParticle(8639.0, 0.14352) }, { 0.007817342138915653d, new GammaParticle(9610.0, 0.12902) }, { 0.007817342138915653d, new GammaParticle(9610.0, 0.12902) } } },

        };
    }
}
    