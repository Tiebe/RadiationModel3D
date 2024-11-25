using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten179m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten179m";
        public override double halfLife { get; } = 384.0d;
        public override double atomicWeight { get; } = 178.94732d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9971d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten179() }, { 7.699999999999999e-06d, new GammaParticle(101600.0, 0.0122) }, { 0.0033d, new GammaParticle(120100.0, 0.01032) }, { 0.08800000000000001d, new GammaParticle(221500.0, 0.0056) }, { 0.205861536555675d, new GammaParticle(9740.0, 0.12729) }, { 0.15654739445960295d, new GammaParticle(57983.0, 0.02138) }, { 0.27192529869654847d, new GammaParticle(59320.0, 0.0209) }, { 0.09013397312860956d, new GammaParticle(67335.0, 0.01841) }, { 0.11483068176584858d, new GammaParticle(68117.0, 0.0182) }, { 0.02469670863723902d, new GammaParticle(69068.0, 0.01795) } } },
            { 0.0029d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium179() }, { 1.0d, new BetaParticle(1, 695000.0) }, { 0.0006d, new GammaParticle(213900.0, 0.0058) }, { 0.0006d, new GammaParticle(222500.0, 0.00557) }, { 0.00021d, new GammaParticle(230100.0, 0.00539) }, { 0.0023d, new GammaParticle(238700.0, 0.00519) }, { 0.0019d, new GammaParticle(281700.0, 0.0044) }, { 0.0003d, new GammaParticle(288900.0, 0.00429) }, { 0.0009d, new GammaParticle(9424.0, 0.13156) }, { 0.0008d, new GammaParticle(56280.0, 0.02203) }, { 0.0015d, new GammaParticle(57535.0, 0.02155) }, { 0.00049d, new GammaParticle(65315.0, 0.01898) }, { 0.00062d, new GammaParticle(66067.0, 0.01877) }, { 0.00013d, new GammaParticle(66981.0, 0.01851) } } },

        };
    }
}
    