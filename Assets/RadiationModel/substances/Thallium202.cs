using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium202 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium202";
        public override double halfLife { get; } = 1077459.84d;
        public override double atomicWeight { get; } = 201.97211d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold202() }, { 1.0d, new BetaParticle(1, -813700.0) }, { 0.915d, new GammaParticle(439560.0, 0.00282) }, { 0.00582d, new GammaParticle(520130.0, 0.00238) }, { 0.00068d, new GammaParticle(960100.0, 0.00129) }, { 0.293819359930248d, new GammaParticle(11777.0, 0.10528) }, { 0.22788302526519863d, new GammaParticle(68894.0, 0.018) }, { 0.38630789161755996d, new GammaParticle(70820.0, 0.01751) }, { 0.13110339757126172d, new GammaParticle(80316.0, 0.01544) }, { 0.16951669305964137d, new GammaParticle(81285.0, 0.01525) }, { 0.03841329548837968d, new GammaParticle(82477.0, 0.01503) } } },

        };
    }
}
    