using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium147m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium147m";
        public override double halfLife { get; } = 55.2d;
        public override double atomicWeight { get; } = 146.93189d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6890000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium147() }, { 1.0d, new BetaParticle(1, 5955450.0) } } },
            { 0.311d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium147() }, { 0.042d, new GammaParticle(72000.0, 0.01722) }, { 0.257d, new GammaParticle(678400.0, 0.00183) }, { 0.0524412148456d, new GammaParticle(7384.0, 0.16791) }, { 0.06717116240015122d, new GammaParticle(45207.0, 0.02743) }, { 0.12003424303100647d, new GammaParticle(45998.0, 0.02695) }, { 0.0385405414038431d, new GammaParticle(52220.0, 0.02374) }, { 0.04856108216884231d, new GammaParticle(52791.0, 0.02349) }, { 0.010020540764999206d, new GammaParticle(53478.0, 0.02318) } } },

        };
    }
}
    