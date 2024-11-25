using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium116";
        public override double halfLife { get; } = 14.1d;
        public override double atomicWeight { get; } = 115.90526d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99977d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin116() }, { 1.0d, new BetaParticle(-1, 1638110.0) }, { 0.0025474d, new GammaParticle(463300.0, 0.00268) }, { 0.000142967d, new GammaParticle(818700.0, 0.00151) }, { 0.00012997d, new GammaParticle(932100.0, 0.00133) }, { 0.00031193d, new GammaParticle(1252600.0, 0.00099) }, { 0.012997000000000002d, new GammaParticle(1293400.0, 0.00096) }, { 0.000103976d, new GammaParticle(1356400.0, 0.00091) }, { 0.000155964d, new GammaParticle(1497100.0, 0.00083) }, { 0.000207952d, new GammaParticle(2112300.0, 0.00059) }, { 5.5887e-05d, new GammaParticle(2225500.0, 0.00056) }, { 1.1697299999999999e-05d, new GammaParticle(2649800.0, 0.00047) }, { 6.947623053095201e-07d, new GammaParticle(3753.0, 0.33036) }, { 2.1852366494288677e-06d, new GammaParticle(25044.0, 0.04951) }, { 4.089905763482815e-06d, new GammaParticle(25271.0, 0.04906) }, { 1.156471525721234e-06d, new GammaParticle(28579.0, 0.04338) }, { 1.3842964162883173e-06d, new GammaParticle(28810.0, 0.04304) }, { 2.2782489056708312e-07d, new GammaParticle(29107.0, 0.0426) } } },
            { 0.00023d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium116() }, { 1.3521568900000001e-05d, new GammaParticle(3388.0, 0.36595) }, { 4.7164500816038344e-05d, new GammaParticle(22983.0, 0.05395) }, { 8.870509839390321e-05d, new GammaParticle(23173.0, 0.0535) }, { 2.4725508282621343e-05d, new GammaParticle(26184.0, 0.04735) }, { 2.9225550790058425e-05d, new GammaParticle(26381.0, 0.047) }, { 4.500042507437084e-06d, new GammaParticle(26641.0, 0.04654) } } },

        };
    }
}
    