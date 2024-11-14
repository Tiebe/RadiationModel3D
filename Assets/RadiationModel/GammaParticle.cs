using System.Collections.Generic;
using RadiationModel.substances;

namespace RadiationModel
{
    public class GammaParticle : RadioactiveSubstance
    {
        public GammaParticle(double wavelength) => this.wavelength = wavelength;
        public override string name { get; } = "Gamma particle";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 0;
        public double wavelength { get; } = 0;
        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new();
    }
}